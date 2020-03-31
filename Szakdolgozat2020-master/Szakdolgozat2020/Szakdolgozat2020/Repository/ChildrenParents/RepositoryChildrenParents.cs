using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.ChildParent;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    public partial class RepositoryChildrenParents
    {
        List<ChildParent> childrenparents;


        /// <summary>
        /// Beállytja  gyerek-szülőt
        /// </summary>
        /// <param name="children"> Gyerek-szülő </param>
        public void setChildParent(List<ChildParent> childrenparents)
        {
            this.childrenparents = childrenparents;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns>A tábla szerkezete adattal feltöltve </returns>
        public DataTable getChildrenParentsListToDatabse()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Azónosító:", typeof(int));
                dt.Columns.Add("Szülő neve:", typeof(string));
                dt.Columns.Add("Gyerek neve:", typeof(string));

                foreach (ChildParent line in childrenparents)
                {
                    dt.Rows.Add(line.getCpID(), line.getChildName(), line.getParentname());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dt;
        }


        /// <summary>
        /// A gyermek-szülő törlése a listából
        /// </summary>
        /// <param name="id">Gyermek-szülő id-ja</param>
        public void deleteChildParentInList(int id)
        {
            ChildParent chi = childrenparents.Find(x => x.getCpID() == id);
            if (chi != null)
            {
                childrenparents.Remove(chi);
            }
            else
            {
                throw new RepositoryChildParentExceptionCantDelete("Nem lehet törölni a gyermek-szülő párt a listából!");
            }
        }

        /// <summary>
        /// Gyermek-szülő módosítása a listában
        /// </summary>
        /// <param name="id">Gyermek-szülő id-ja</param>
        /// <param name="modified">Módosított gyermek-szülő</param>
        public void updateChildParentInList(int id, ChildParent modified)
        {
            ChildParent chipar = childrenparents.Find(x => x.getCpID() == id);
            if (chipar != null)
            {
                chipar.updateL(modified);
            }
            else
            {
                throw new RepositoryChildParentExceptionCantMoodify("Nem lehet modósitani a listában a gyermek-szülő párt!");
            }
        }

        /// <summary>
        /// Újy gyermek hozzáadaása a listához
        /// </summary>
        /// <param name="newChildParent"></param>
        public void addChildParentToList(ChildParent newChildParent)
        {
            try
            {
                childrenparents.Add(newChildParent);
            }
            catch (Exception e)
            {
                throw new RepositoryChildParentExceptionCantAdd("Nem lehet új gyermek-szülő párt hozzáadni a listához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns>A következő id</returns>
        public int getnextChildParentId()
        {
            if (childrenparents.Count == 0)
            {
                return 1;
            }
            else
            {
                return childrenparents.Max(x => x.getCpID()) + 1;
            }
        }
    }
}
