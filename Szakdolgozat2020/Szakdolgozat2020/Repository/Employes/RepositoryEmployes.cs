using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Employes;

namespace Szakdolgozat2020.Repository.Employes
{
    partial class RepositoryEmployes
    {
        List<Employe> employes;
        public List<Employe> getEmployes()
        {
            return employes;
        }

        public List<string> getEmployesName()
        {
            //neve tárólására egy lista
            List<string> employesName = new List<string>();
            foreach (Employe employe in employes)
            {
                employesName.Add(employe.getEname());
            }
            return employesName;
        }
        public void setEmploye(List<Employe> employes)
        {
            this.employes = employes;
        }

        public DataTable getEmployesListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosító",typeof(int));
            dt.Columns.Add("Neve:",typeof(string));
            dt.Columns.Add("Lánykori neve:", typeof(string));
            dt.Columns.Add("Dolgozó neme:", typeof(string));
            dt.Columns.Add("Születési idő:", typeof(string));
            dt.Columns.Add("Születési hely:", typeof(string));
            dt.Columns.Add("Betöltött munkakör:", typeof(string));
            dt.Columns.Add("Lakcím:", typeof(string));
            dt.Columns.Add("Felhasználó név:", typeof(string));
            dt.Columns.Add("Jelszó:", typeof(string));
            foreach (Employe line in employes)
            {
                dt.Rows.Add(line.getEID(), line.getEname(), line.getEmaidenname(),line.getEsex(),line.getEallbirthday(),line.getEbirthplace(),line.getEjob(),line.getElocation(),line.getEuname(),line.getEpasword());
            }
            return dt;
        }
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
                employes.Add(line);
            }
        }
        public int getEmployNumber(string employeName)
        {
            Employe employe = employes.Find(f => f.getEname() == employeName);
            return employe.getEID();
        }
    }
}
