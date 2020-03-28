using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Soul;

namespace Szakdolgozat2020
{
    public partial class RepositorySouls
    {
        List<SoulM> souls;
        /// <summary>
        /// Kigyűjti
        /// </summary>
        /// <returns>Valamit</returns>
        public List<string> getSoulName()
        {
            //neve tárólására egy lista
            List<string> soulsV = new List<string>();
            foreach (SoulM soul in souls)
            {
                if (!soulsV.Contains(soul.getCname()))
                {
                    soulsV.Add(soul.getCname());
                }
            }
            soulsV.Sort();
            return soulsV;
        }

        /// <summary>
        /// Beállít akták
        /// </summary>
        /// <param name="souls"> Akta </param>
        public void setSouls(List<SoulM> souls)
        {
            this.souls = souls;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getSoulsListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Akta azonosító:", typeof(int));
                dt.Columns.Add("Gyermek neve:", typeof(string));
                dt.Columns.Add("Tipusa:", typeof(string));
                dt.Columns.Add("Részletek:", typeof(string));
                dt.Columns.Add("Különleges eljárás:", typeof(string));
                dt.Columns.Add("Dátum:", typeof(string));
                dt.Columns.Add("Felvett neve", typeof(string));
                foreach (SoulM line in souls)
                {
                    dt.Rows.Add(line.getSID(), line.getCname(), line.getType(), line.getDetails(), line.getSpecialT(), line.getTreatDate(), line.getByname());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// A listából törli a aktát
        /// </summary>
        /// <param name="id">szülő id-ja</param>
        public void deleteSoulInList(int id)
        {
            SoulM sol = souls.Find(x => x.getSID() == id);
            if (sol != null)
            {
                souls.Remove(sol);
            }
            else
            {
                throw new RepositorySoulsExceptionCantDelete("Nem lehet törölni az aktát a listából!");
            }
        }

        /// <summary>
        /// A listban az akta módosítása
        /// </summary>
        /// <param name="id">akta id-ja</param>
        /// <param name="modified">Módosított akta</param>
        public void updateSoulInList(int id, SoulM modified)
        {
            SoulM par = souls.Find(x => x.getSID() == id);
            if (par != null)
            {
                par.updateL(modified);
            }
            else
            {
                throw new RepositorySoulsExceptionCantMoodify("Nem lehet modósitani a listában az aktát!");
            }
        }

        /// <summary>
        /// Az új akta hozzáadása a listához
        /// </summary>
        /// <param name="newParent">Az új akta</param>
        public void addSoulsToList(SoulM newSoul)
        {
            try
            {
                souls.Add(newSoul);
            }
            catch (Exception e)
            {
                throw new RepositorySoulExceptionCantAdd("Nem lehet új aktát hozzáadni a lsitához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextSoulId()
        {
            if (souls.Count == 0)
            {
                return 1;
            }
            else
            {
                return souls.Max(x => x.getSID()) + 1;
            }
        }
    }
}
