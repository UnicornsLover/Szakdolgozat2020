using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.EventChildren;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    public partial class RepositoryEventsChildren
    {
        List<EventChild> eventchilds;
        

        /// <summary>
        /// Beállít adatok
        /// </summary>
        /// <param name="childrenviews"> adat </param>
        public void setChildrenViews(List<EventChild> eventchilds)
        {
            this.eventchilds = eventchilds;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getEventChildrensListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Azonosító:", typeof(int));
                dt.Columns.Add("Gyerek neve:", typeof(string));
                dt.Columns.Add("Esemény neve:", typeof(string));
                dt.Columns.Add("Dátum:", typeof(string));
                foreach (EventChild line in eventchilds)
                {
                    dt.Rows.Add(line.getecID(), line.getChildrenName(), line.getEventName(), line.getDateTime());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// A listából törli az esemény gyerek párt
        /// </summary>
        /// <param name="id">párok id-ja</param>
        public void deleteEventChildrenViewInList(int id)
        {
            EventChild evechi = eventchilds.Find(x => x.getecID() == id);
            if (evechi != null)
            {
                eventchilds.Remove(evechi);
            }
            else
            {
                throw new RepositoryEventChildrenExceptionCantDelete("Nem lehet törölni a esemény gyereket a listából!");
            }
        }

        /// <summary>
        /// A listban a párok módosítása
        /// </summary>
        /// <param name="id">Párok id-ja</param>
        /// <param name="modified">Módosított pár</param>
        public void updateEventChildrenViewInList(int id, EventChild modified)
        {
            EventChild chv = eventchilds.Find(x => x.getecID() == id);
            if (chv != null)
            {
                chv.updateL(modified);
            }
            else
            {
                throw new RepositoryEventChildrenExceptionCantMoodify("Nem lehet modósitani a listában a párt!");
            }
        }

        /// <summary>
        /// Az új párok hozzáadása a listához
        /// </summary>
        /// <param name="newEventChildren">Az új pár</param>
        public void addEventChildrenViewToList(EventChild newEventChildren)
        {
            try
            {
                eventchilds.Add(newEventChildren);
            }
            catch (Exception e)
            {
                throw new RepositoryEventChilldrenExceptionCantAdd("Nem lehet új párt hozzáadni a lsitához!");
            }
        }
        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextChildrenViewId()
        {
            if (eventchilds.Count == 0)
            {
                return 1;
            }
            else
            {
                return eventchilds.Max(x => x.getecID()) + 1;
            }
        }
    }
}
