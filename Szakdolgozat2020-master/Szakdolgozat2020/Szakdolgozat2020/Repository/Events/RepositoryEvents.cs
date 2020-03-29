using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Event;

namespace Szakdolgozat2020.Repository.Events
{
    public partial class RepositoryEvents
    {
        List<Event> events;

        public List<string> getEventsname()
        {
            //neve tárólására egy lista
            List<string> eventsName = new List<string>();
            foreach (Event eve in events)
            {
                if (!eventsName.Contains(eve.getTitle()))
                {
                    eventsName.Add(eve.getTitle());
                }
            }
            eventsName.Sort();
            return eventsName;
        }

        /// <summary>
        /// Beállít iskolákat
        /// </summary>
        /// <param name="schools"> Eseményeket </param>
        public void setEvents(List<Event> events)
        {
            this.events = events;
        }

        public string getSchoolIdInsert(string adat)
        {
            string a = events.Find(x => x.getTitle() == adat).getEID().ToString();
            return a;
        }
        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getEventsListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Esemény azonosító:", typeof(int));
                dt.Columns.Add("Cím:", typeof(string));
                dt.Columns.Add("Részletek:", typeof(string));
                dt.Columns.Add("Felvevője:", typeof(string));
                foreach (Event line in events)
                {
                    dt.Rows.Add(line.getEID(), line.getTitle(), line.getDetails(), line.getBy());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        public string getEventID(string adat)
        {

            string a = events.Find(x => x.getTitle() == adat).getEID().ToString();
            return a;
        }

        /// <summary>
        /// Megszámolja  a az eseményeket
        /// </summary>
        /// <returns>Események száma</returns>
        public int getEventsNumber()
        {
            int db = 0;
            foreach (Event e in events)
            {
                db++;
            }
            return db;
        }
        /// <summary>
        /// A listából törli az eseményt
        /// </summary>
        /// <param name="id">esemény id-ja</param>
        public void deleteEventInList(int id)
        {
            Event eve = events.Find(x => x.getEID() == id);
            if (eve != null)
            {
                events.Remove(eve);
            }
            else
            {
                throw new RepositoryEventExceptionCantDelete("Nem lehet törölni az eseményt a listából!");
            }
        }

        /// <summary>
        /// A listban az esemény módosítása
        /// </summary>
        /// <param name="id">Esemény id-ja</param>
        /// <param name="modified">Módosított esemény</param>
        public void updateEventInList(int id, Event modified)
        {
            Event sch = events.Find(x => x.getEID() == id);
            if (sch != null)
            {
                sch.updateL(modified);
            }
            else
            {
                throw new RepositoryEventExceptionCantMoodify("Nem lehet modósitani a listában az iskolát!");
            }
        }

        /// <summary>
        /// Az új esemény hozzáadása a listához
        /// </summary>
        /// <param name="newEvent">Az új esemény</param>
        public void addEventToList(Event newEvent)
        {
            try
            {
                events.Add(newEvent);
            }
            catch (Exception e)
            {
                throw new RepositoryEventExceptionCantAdd("Nem lehet új eseményt hozzáadni a lsitához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextEventId()
        {
            if (events.Count == 0)
            {
                return 1;
            }
            else
            {
                return events.Max(x => x.getEID()) + 1;
            }
        }

    }
}
