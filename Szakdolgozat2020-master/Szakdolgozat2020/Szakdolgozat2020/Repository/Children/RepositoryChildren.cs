﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Children;

namespace Szakdolgozat2020.Repository.Children
{
    public partial class RepositoryChildren
    {
        List<Child> children;

        /// <summary>
        /// A gyerkek neveit kigyüjti
        /// </summary>
        /// <returns>Gyerek nevek</returns>
        public List<string> getChildrenName()
        {
            //neve tárólására egy lista
            List<string> chilD = new List<string>();
            foreach (Child chi in children)
            {
                if (!chilD.Contains(chi.getCcname()))
                {
                    chilD.Add(chi.getCcname());
                }
            }
            chilD.Sort();
            return chilD;
        }
        

        /// <summary>
        /// Beállítja  gyereket
        /// </summary>
        /// <param name="children"> Gyerek a lsitából </param>
        public void setChild(List<Child> children)
        {
            this.children = children;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns>A tábla szerkezete adattal feltöltve </returns>
        public DataTable getChildrenListToDatabse()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Azónosító:", typeof(int));
                dt.Columns.Add("Neve:", typeof(string));
                dt.Columns.Add("Neme:", typeof(string));
                dt.Columns.Add("Személyigazolványszám:", typeof(string));
                dt.Columns.Add("TAJ szám:", typeof(string));
                dt.Columns.Add("Születésnap:", typeof(string));
                dt.Columns.Add("Születési hely:", typeof(string));
                dt.Columns.Add("Belépés dátuma:", typeof(string));
                dt.Columns.Add("Intézmény helyszíne:", typeof(string));

                foreach (Child line in children)
                {
                    dt.Rows.Add(line.getCID(), line.getCcname(), line.getCsex(), line.getCidcard(), line.getCtajNumber(), line.getCbirthday(), line.getCbirthdayplace(), line.getCcoming(), line.getClocation());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Mgszámolja gyerekeket
        /// </summary>
        /// <returns>Gyerekek száma</returns>
        public int getChildrenNumber()
        {
            int db = 0;
            foreach (Child s in children)
            {
                db++;
            }
            return db;
        }

        /// <summary>
        /// A gyermek törlése a listából
        /// </summary>
        /// <param name="id">Gyermek id-ja</param>
        public void deleteChildInList(int id)
        {
            Child chi = children.Find(x => x.getCID() == id);
            if (chi != null)
            {
                children.Remove(chi);
            }
            else
            {
                throw new RepositoryChildExceptionCantDelete("Nem lehet törölni a gyermeket a listából!");
            }
        }

        /// <summary>
        /// A gyerek id-ja mgszerzése név alapján
        /// </summary>
        /// <param name="adat">A gyerek neve</param>
        /// <returns>Névhez tartozó id.</returns>
        public string getChildrenId(string adat)
        {
            
            string a = children.Find(x => x.getCcname() == adat).getCID().ToString();
            return a;
        }

        /// <summary>
        /// Gyermek módosítása a listában
        /// </summary>
        /// <param name="id">Gyermek id-ja</param>
        /// <param name="modified">Módosított gyermek</param>
        public void updateChildInList(int id, Child modified)
        {
            Child chi = children.Find(x => x.getCID() == id);
            if (chi != null)
            {
                chi.updateL(modified);
            }
            else
            {
                throw new RepositoryChildExceptionCantMoodify("Nem lehet modósitani a listában a gyermeket!");
            }
        }

        /// <summary>
        /// Újy gyermek hozzáadaása a listához
        /// </summary>
        /// <param name="newChild"> Az új gyerek</param>
        public void addChildToList(Child newChild)
        {
            try
            {
                children.Add(newChild);
            }
            catch (Exception e)
            {
                throw new RepositoryChildExceptionCantAdd("Nem lehet új gyermeket hozzáadni a listához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns>A következő id</returns>
        public int getnextChildId()
        {
            if (children.Count == 0)
            {
                return 1;
            }
            else
            {
                return children.Max(x => x.getCID()) + 1;
            }
        }
    }
}
