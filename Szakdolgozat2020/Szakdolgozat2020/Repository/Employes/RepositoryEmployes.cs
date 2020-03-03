using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Employes;

namespace Szakdolgozat2020.Repository.Employes
{
    partial class RepositoryEmployes
    {
        List<Employe> employees;
        /// <summary>
        /// Dolgozók lekérése a listából
        /// </summary>
        /// <returns>Dolgozók adatokkal</returns>
        public List<Employe> getEmployes()
        {
            return employees;
        }

        public void updateChangePassword(int id)
        {
            Employe emp = employees.Find(x => x.getEID() == id);
            if (emp != null)
            {
                emp.updateL2(emp);
            }
            else
            {
                throw new RepositoryExceptionCantMoodify("Nem lehet modósitani a listában!");
            }
        }
        /// <summary>
        /// Dolgozók neveit kigyűjti
        /// </summary>
        /// <returns></returns>
        public List<string> getEmployesName()
        {
            //neve tárólására egy lista
            List<string> employesName = new List<string>();
            foreach (Employe employe in employees)
            {
                employesName.Add(employe.getEname());
            }
            return employesName;
        }

        /// <summary>
        /// Beállít dolgozó
        /// </summary>
        /// <param name="employees"> Dolgozó </param>
        public void setEmploye(List<Employe> employees)
        {
            this.employees = employees;
        }

        /// <summary>
        /// Adattábla feltöltése
        /// </summary>
        /// <returns> Feltöltve a tábla</returns>
        public DataTable getEmployesListToDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Azonosító:", typeof(int));
                dt.Columns.Add("Neve:", typeof(string));
                dt.Columns.Add("Lánykori neve:", typeof(string));
                dt.Columns.Add("Dolgozó neme:", typeof(string));
                dt.Columns.Add("Születési idő:", typeof(string));
                dt.Columns.Add("Születési hely:", typeof(string));
                dt.Columns.Add("Betöltött munkakör:", typeof(string));
                dt.Columns.Add("Lakcím:", typeof(string));
                dt.Columns.Add("Felhasználó név:", typeof(string));
                dt.Columns.Add("Jelszó:", typeof(string));
                foreach (Employe line in employees)
                {
                    dt.Rows.Add(line.getEID(), line.getEname(), line.getEmaidenname(), line.getEsex(), line.getEallbirthday(), line.getEbirthplace(), line.getEjob(), line.getElocation(), line.getEuname(), line.getEpasword());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
            return dt;
        }

        /// <summary>
        /// Adat táblából a listába töltés
        /// </summary>
        /// <param name="dt"></param>
        public void DataTableToEmployeList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string ename = row[1].ToString();
                string emaidenname = row[2].ToString();
                string esex = row[3].ToString();
                string  eallbirthday= row[4].ToString();
                string ebirthplace = row[5].ToString();
                string ejob = row[6].ToString();
                string elocation = row[7].ToString();
                string euname = row[8].ToString();
                string epassword = row[9].ToString();
                Employe line = new Employe(id, ename, emaidenname, esex, eallbirthday, ebirthplace, ejob, elocation, euname, epassword);
                employees.Add(line);
            }
        }
        public int getEmployNumber(string employeName)
        {
            Employe employe = employees.Find(f => f.getEname() == employeName);
            return employe.getEID();
        }

        /// <summary>
        /// A listából törli a dolgozót
        /// </summary>
        /// <param name="id">dolgozó id-ja</param>
        public void deleteEmployeInList(int id)
        {
            Employe emp = employees.Find(x => x.getEID() == id);
            if (emp != null)
            {
                employees.Remove(emp); 
            }
            else 
            {
                throw new RepositoryExceptionCantDelete("Nem lehet törölni a dolgozót a listából!");
            }
        }

        /// <summary>
        /// A listban a dolgozó módosítása
        /// </summary>
        /// <param name="id">Dolgozó id-ja</param>
        /// <param name="modified">Módosított dolgozó</param>
        public void updateEmployeeInList(int id, Employe modified)
        {
            Employe emp = employees.Find(x => x.getEID() == id);
            if (emp != null)
            {
                emp.updateL(modified);
            }
            else
            {
                throw new RepositoryExceptionCantMoodify("Nem lehet modósitani a listában!");
            }
        }

        /// <summary>
        /// Az új dolgozó hozzáadása a listához
        /// </summary>
        /// <param name="newEmployee">Az új dolgozó</param>
        public void addEmployeeToList(Employe newEmployee)
        {
            try
            {
                employees.Add(newEmployee);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("Nem lehet új dolgozót hozzáadni!");
            }
        }

        public Employe getEmploye(int id)
        {
            return employees.Find(x => x.getEID() == id);
        }

        /// <summary>
        /// Megkeresi a legnagyobb id-t és egyet hozzáad vag ha első akkor egyessel kezdi
        /// </summary>
        /// <returns> A következő id</returns>
        public int getnextEmployesId()
        {
            if (employees.Count == 0)
            {
                return 1;
            }
            else
            {
                return employees.Max(x => x.getEID()) + 1;
            }
        }
    }
}
