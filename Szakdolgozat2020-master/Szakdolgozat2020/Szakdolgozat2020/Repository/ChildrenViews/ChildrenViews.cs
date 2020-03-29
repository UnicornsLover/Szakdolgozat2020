using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Children;
using Szakdolgozat2020.Modell.School;
using Szakdolgozat2020.Modell.SchoolChildren;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    public partial class ChildrenViews
    {
        List<ChildrenView> childrenviews;

        /// <summary>
        /// Beállít adatok
        /// </summary>
        /// <param name="childrenviews"> adat </param>
        public void setChildrenViews(List<ChildrenView> childrenviews)
        {
            this.childrenviews = childrenviews;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getChildrensListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Azonosító:", typeof(int));
                dt.Columns.Add("Iskola neve:", typeof(string));
                dt.Columns.Add("Gyerek neve:", typeof(string));
                dt.Columns.Add("Kezdés:", typeof(string));
                dt.Columns.Add("Várható befejezés", typeof(string));
                dt.Columns.Add("Tipusa:", typeof(string));
                dt.Columns.Add("Osztályfönők", typeof(string));
                foreach (ChildrenView line in childrenviews)
                {
                    dt.Rows.Add(line.getscID(), line.getSchoolName(), line.getChildrenName(), line.getFromDate(), line.getExDate(), line.getType(), line.getHeadteacher());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// A listából törli a párokat
        /// </summary>
        /// <param name="id">párok id-ja</param>
        public void deleteChildrenViewInList(int id)
        {
            ChildrenView chiview = childrenviews.Find(x => x.getscID() == id);
            if (chiview != null)
            {
                childrenviews.Remove(chiview);
            }
            else
            {
                throw new RepositoryChildrenViewsExceptionCantDelete("Nem lehet törölni a szülőt a listából!");
            }
        }

        /// <summary>
        /// A listban a párok módosítása
        /// </summary>
        /// <param name="id">Párok id-ja</param>
        /// <param name="modified">Módosított pár</param>
        public void updateChildrenViewInList(int id, ChildrenView modified)
        {
            ChildrenView chv = childrenviews.Find(x => x.getscID() == id);
            if (chv != null)
            {
                chv.updateL(modified);
            }
            else
            {
                throw new RepositoryChildrenViewExceptionCantMoodify("Nem lehet modósitani a listában a párt!");
            }
        }

        /// <summary>
        /// Az új párok hozzáadása a listához
        /// </summary>
        /// <param name="newChildrenView">Az új pár</param>
        public void addChildrenViewToList(ChildrenView newChildrenView)
        {
            try
            {
                childrenviews.Add(newChildrenView);
            }
            catch (Exception e)
            {
                throw new RepositoryChilldrenViewExceptionCantAdd("Nem lehet új párt hozzáadni a lsitához!");
            }
        }
        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextChildrenViewId()
        {
            if (childrenviews.Count == 0)
            {
                return 1;
            }
            else
            {
                return childrenviews.Max(x => x.getscID()) + 1;
            }
        }
    }
}
