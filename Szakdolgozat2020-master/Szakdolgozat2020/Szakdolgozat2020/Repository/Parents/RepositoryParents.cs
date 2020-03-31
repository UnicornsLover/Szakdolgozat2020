using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Parents;

namespace Szakdolgozat2020.Repository.Parents
{
    partial class RepositoryParents
    {
        List<Parent> parents;

        /// <summary>
        /// Szülők neveit kigyűjti
        /// </summary>
        /// <returns>Szülő nevekpublic</returns>
        public List<string> getParentsName()
        {
            //neve tárólására egy lista
            List<string> parentsName = new List<string>();
            foreach (Parent parent in parents)
            {
                if (!parentsName.Contains(parent.getPname()))
                {
                    parentsName.Add(parent.getPname());
                }
            }
            parentsName.Sort();
            return parentsName;
        }
        public string getParentIdInsert(string adat)
        {
            string a = parents.Find(x => x.getPname() == adat).getPID().ToString();
            return a;
        }
        /// <summary>
        /// Beállít szülők
        /// </summary>
        /// <param name="parents"> Szülő </param>
        public void setParents(List<Parent> parents)
        {
            this.parents = parents;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getParentsListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Szülő azonosító:", typeof(int));
                dt.Columns.Add("Neve:", typeof(string));
                dt.Columns.Add("Neme:", typeof(string));
                dt.Columns.Add("Születési idő:", typeof(string));
                dt.Columns.Add("Személyigazolvány szám:", typeof(string));
                dt.Columns.Add("Engedély:", typeof(string));
                dt.Columns.Add("Felhasználónév:", typeof(string));
                dt.Columns.Add("Jelszó:", typeof(string));
                
                foreach (Parent line in parents)
                {
                    dt.Rows.Add(line.getPID(), line.getPname(), line.getPSex(),line.getPBirth(), line.getPIdcard(), line.getPLoginpermission(), line.getPUser(), line.getPPassword());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// Megszámolja  a szülőket
        /// </summary>
        /// <returns>Szülőket száma</returns>
        public int getParentsNumber()
        {
            int db = 0;
            foreach (Parent p in parents)
            {
                db++;
            }
            return db;
        }
        /// <summary>
        /// A listából törli a szülőket
        /// </summary>
        /// <param name="id">szülő id-ja</param>
        public void deleteParentInList(int id)
        {
            Parent emp = parents.Find(x => x.getPID() == id);
            if (emp != null)
            {
                parents.Remove(emp);
            }
            else
            {
                throw new RepositoryParentsExceptionCantDelete("Nem lehet törölni a szülőt a listából!");
            }
        }

        /// <summary>
        /// A listban a szülő módosítása
        /// </summary>
        /// <param name="id">Szülő id-ja</param>
        /// <param name="modified">Módosított szülő</param>
        public void updateParentInList(int id, Parent modified)
        {
            Parent par = parents.Find(x => x.getPID() == id);
            if (par != null)
            {
                par.updateL(modified);
            }
            else
            {
                throw new RepositoryParentExceptionCantMoodify("Nem lehet modósitani a listában a szülőt!");
            }
        }

        /// <summary>
        /// Az új szülő hozzáadása a listához
        /// </summary>
        /// <param name="newParent">Az új szülő</param>
        public void addParentsToList(Parent newParent)
        {
            try
            {
                parents.Add(newParent);
            }
            catch (Exception e)
            {
                throw new RepositoryParentExceptionCantAdd("Nem lehet új szülőt hozzáadni a lsitához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextParentId()
        {
            if (parents.Count == 0)
            {
                return 1;
            }
            else
            {
                return parents.Max(x => x.getPID()) + 1;
            }
        }
    }
}
