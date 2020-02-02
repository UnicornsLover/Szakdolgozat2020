using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Employes
{
    class Employes
    {
        private int eID;
        private string ename;
        private string emaidenname;
        private string esex;
        private string ebirthdayDay;
        private string ebirthdayMonth;
        private string ebirthdayYear;
        private string ebirthplace;
        private string ejob;
        private string elocation;
        private string euname;
        private string epassword;

        public Employes(int eID, string ename, string emaidenname, string esex, string ebirthdayDay, string ebirthdayMonth, string ebirthdayYear, string ebirthplace, string ejob, string elocation, string euname, string epassword)
        {
            this.eID = eID;
            this.ename = ename;
            this.emaidenname = emaidenname;
            this.esex = esex;
            this.ebirthdayDay = ebirthdayDay;
            this.ebirthdayMonth = ebirthdayMonth;
            this.ebirthdayYear = ebirthdayYear;
            this.ebirthplace = ebirthplace;
            this.ejob = ejob;
            this.elocation = elocation;
            this.euname = euname;
            this.epassword = epassword;
        }

        //isValid items !!!!!!!!!!!!!!
        //Custemer PizzaTobbTabla

        //******************************************SETTER***************************************
        public void setEID(int id)
        {
            this.eID = id;
        }
        public void setEname(string name)
        {
            this.ename = name;
        }
        public void seteEmaidenname(string emname)
        {
            this.emaidenname = emname;
        }
        public void setEsex(string esex)
        {
            this.esex = esex;
        }
        public void setEbirthdayDay(string bday)
        {
            this.ebirthdayDay = bday;
        }
        public void setEbirthdayMonth(string bmonth)
        {
            this.ebirthdayMonth = bmonth;
        }
        public void setEbirthdayYear(string bYear)
        {
            this.ebirthdayYear = bYear;
        }
        public void setEbirtplace(string bPlace)
        {
            this.ebirthplace = bPlace;
        }
        public void setEjob(string job)
        {
            this.ejob = job;
        }
        public void setElocation(string location)
        {
            this.elocation = location;
        }
        public void setEuname(string uname)
        {
            this.euname = uname;
        }
        public void setEpassword(string password)
        {
            this.epassword = password;
        }
        //******************************************GETTER***************************************
        public int getEID()
        {
            return eID;
        }
        public string getEname()
        {
            return ename;
        }
        public string getEmaidenname()
        {
            return emaidenname;
        }
        public string getEsex()
        {
            return esex;
        }
        public string getEbirthDay()
        {
            return ebirthdayDay;
        }
        public string getEbirthMonth()
        {
            return ebirthdayMonth;
        }
        public string getEbirthYear()
        {
            return ebirthdayYear;
        }
        public string getEbirthplace()
        {
            return ebirthplace;
        }
        public string getEjob()
        {
            return ejob;
        }
        public string getElocation()
        {
            return elocation;
        }
        public string getEuname()
        {
            return euname;
        }
        public string getEpasword()
        {
            return epassword;
        }
        
    }
}
