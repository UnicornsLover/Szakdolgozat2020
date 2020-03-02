using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Employes
{
    partial class Employe
    {
        private int eID;
        private string ename;
        private string emaidenname;
        private string esex;
        private string allbirth;
        private string ebirthplace;
        private string ejob;
        private string elocation;
        private string euname;
        private string epassword;
        
        /// <summary>
        /// Konstruktor a dolgozó létrehozásához
        /// </summary>
        /// <param name="eID">Azonosító</param>
        /// <param name="ename">Neve</param>
        /// <param name="emaidenname">Lánykori neve, ha férfu ez jelenik meg "-"</param>
        /// <param name="esex">Neme</param>
        /// <param name="allbirth">Születési dátum</param>
        /// <param name="ebirthplace">Születési hely</param>
        /// <param name="ejob">Munka tipusa</param>
        /// <param name="elocation">Körzethez való tartózása  acégen belül</param>
        /// <param name="euname">Felhasználó név</param>
        /// <param name="epassword">Jelszó</param>
        public Employe(int eID, string ename, string emaidenname, string esex, string allbirth, string ebirthplace, string ejob, string elocation, string euname, string epassword)
        {
            this.eID = eID;
            this.ename = ename;
            this.emaidenname = emaidenname;
            if (esex == "False")
            {
                esex = "férfi";
                this.esex = esex;
            }
            else if(esex == "True")
            {
                esex = "nő";
                this.esex = esex;
            }
            this.allbirth = allbirth;
            this.ebirthplace = ebirthplace;
            this.ejob = ejob;
            this.elocation = elocation;
            this.euname = euname;
            this.epassword = epassword;
        }

        /// <summary>
        /// A dolgozó módosítása
        /// </summary>
        /// <param name="modified">Módosított dolgozó frissítés a List-hez</param>
        public void updateL(Employe modified)
        {
            this.ename = modified.getEname();
            this.emaidenname = modified.getEmaidenname();
            this.esex = modified.getEsex();
            this.allbirth = modified.getEallbirthday();
            this.ebirthplace = modified.getEbirthplace();
            this.ejob = modified.getEjob();
            this.elocation = modified.getElocation();
            this.euname = modified.getEuname();
            this.epassword = modified.getEpasword();
        }

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
        public void setEallbirth(string allbirth)
        {
            this.allbirth = allbirth;
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
        public string getEallbirthday()
        {
            return allbirth;
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
