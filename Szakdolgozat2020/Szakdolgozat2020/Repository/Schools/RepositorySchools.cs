using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.School;

namespace Szakdolgozat2020.Repository.Schools
{
    partial class RepositorySchools
    {
        List<School> schools;
        public List<string> getSchoolsName()
        {
            //neve tárólására egy lista
            List<string> schoolsName = new List<string>();
            foreach (School school in schools)
            {
                schoolsName.Add(school.getName());
            }
            return schoolsName;
        }

        /// <summary>
        /// Beállít iskolákat
        /// </summary>
        /// <param name="schools"> Iskolák </param>
        public void setSchools(List<School> schools)
        {
            this.schools = schools;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> A tábla szerkezete adattal feltöltve </returns>
        public DataTable getSchoolsListToDatabase()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Iskola azonosító:", typeof(int));
                dt.Columns.Add("Neve:", typeof(string));
                dt.Columns.Add("Helye:", typeof(string));
                dt.Columns.Add("Telefonszám:", typeof(string));
                foreach (School line in schools)
                {
                    dt.Rows.Add(line.getSID(), line.getName(), line.getLocation(), line.getPhone());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return dt;
        }

        /// <summary>
        /// Megszámolja  a az iskolákat
        /// </summary>
        /// <returns>Iskolák száma</returns>
        public int getSchoolsNumber()
        {
            int db = 0;
            foreach (School p in schools)
            {
                db++;
            }
            return db;
        }
        /// <summary>
        /// A listából törli a iskolát
        /// </summary>
        /// <param name="id">iskola id-ja</param>
        public void deleteSchoolInList(int id)
        {
            School sch = schools.Find(x => x.getSID() == id);
            if (sch != null)
            {
                schools.Remove(sch);
            }
            else
            {
                throw new RepositorySchoolExceptionCantDelete("Nem lehet törölni az iskolát a listából!");
            }
        }

        /// <summary>
        /// A listban az iskola módosítása
        /// </summary>
        /// <param name="id">Iskola id-ja</param>
        /// <param name="modified">Módosított iskola</param>
        public void updateSchoolInList(int id, School modified)
        {
            School sch = schools.Find(x => x.getSID() == id);
            if (sch != null)
            {
                sch.updateL(modified);
            }
            else
            {
                throw new RepositorySchoolExceptionCantMoodify("Nem lehet modósitani a listában az iskolát!");
            }
        }

        /// <summary>
        /// Az új iskola hozzáadása a listához
        /// </summary>
        /// <param name="newSchool">Az új iskola</param>
        public void addSchoolToList(School newSchool)
        {
            try
            {
                schools.Add(newSchool);
            }
            catch (Exception e)
            {
                throw new RepositorySchoolExceptionCantAdd("Nem lehet új iskolát hozzáadni a lsitához!");
            }
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vagy ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextSchoolId()
        {
            if (schools.Count == 0)
            {
                return 1;
            }
            else
            {
                return schools.Max(x => x.getSID()) + 1;
            }
        }
    }
}
