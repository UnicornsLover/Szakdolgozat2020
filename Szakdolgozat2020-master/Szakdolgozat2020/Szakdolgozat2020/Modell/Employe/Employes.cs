﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string idcard;
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
        /// /// <param name="idcard">Személyigazolványszám</param>
        /// <param name="euname">Felhasználó név</param>
        /// <param name="epassword">Jelszó</param>
        public Employe(int eID, string ename, string emaidenname, string esex, string allbirth, string ebirthplace, string ejob, string elocation, string idcard, string euname, string epassword)
        {
            //**********Valid**********
            if (!isValidName(ename))
            {
                throw new ModellEmployeNotValidNameException("Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen. Számot ne tartalamzzon. Kérlek próbáld újra!");
            }
            if (!isValidMaidenName(emaidenname))
            {
                throw new ModellEmployeNotValidMaidenNameException("Nem megfelelő 'Lánykori neve' mező, kezdje nagy betűvel a nevet. U = ugyan az, X = nincs változás a nevében");
            }
            if (!isValidSex(esex))
            {
                throw new ModellEmployeNotValidSexException("Nem megfelelő 'Neme' mező, kattintson a lefele mutató nyilra 'Neme' mezőnél és a legördülő menő segítségével válasza ki a nemét.");
            }
            if (!isValidBirthDay(allbirth))
            {
                throw new ModellNotValidEmployeBirthDayDateException("Nem megfelelő 'Születési idő:' mező, kérem állítsa be a felvett személy születési dátumát.");
            }
            if (!isValidBirthPlace(ebirthplace))
            {
                throw new ModellEmployeNotValidBirthPlacesException("Nem megfelelő 'Születési hely' mező, kezdje nagy betűvel a város nevet. Kérem próbálja újra.");
            }
            if (!isValidLocation(elocation))
            {
                throw new ModellEmployeNotValidLocationException("Nem megfelelő 'Lakcím (lakcím kártya)' mező , kezdje nagy betűvel a város nevét, irányitó számot ne írjon, tartalmaznia kell a házszámot is. Kérem próbálja újra.");
            }
            if (!isValidJob(ejob))
            {
                throw new ModellEmployeNotValidJobExeption("Nem megfelelő 'Betöltött munkakör' mező, kattintson a lefele mutató nyilra 'Betöltött munkakör' mezőnél és a legördülő menő segítségével válasza ki a betöltött munkakör fajtát.");
            }
            if (!isValidIdCard(idcard))
            {
                throw new MedellNotValidEmpIdcardException("Nem megfelelő 'Személyigazolvány szám:' mező. Kérlek figyelj a formátumra. Pl: 123456AB");
            }
            //**********Set***********
            this.eID = eID;
            this.ename = ename;
            this.emaidenname = emaidenname;
            this.esex = esex;
            this.allbirth = allbirth;
            this.ebirthplace = ebirthplace;
            this.ejob = ejob;
            this.elocation = elocation;
            this.idcard = idcard;
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
            this.idcard = modified.getIdcard();
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
        public void setIdcard(string idcard)
        {
            this.idcard = idcard;
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
        public string getIdcard()
        {
            return idcard;
        }
        public string getEuname()
        {
            return euname;
        }
        public string getEpasword()
        {
            return epassword;
        }

        //****************************************************Validation********************************************


        public bool isValidBirthPlace(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i = i + 1)
            {
                if (!char.IsLetter(name.ElementAt(i)) && (!char.IsWhiteSpace(name.ElementAt(i))))
                {
                    return false;
                } 
            } 
            return true;
        }
        public bool isValidLocation(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }
            if (name.Length <= 5)
            {
                return false;
            }
            if (name.Contains("([0-9])"))
            {
                return false;
            }
            return true;
        }

        public bool isValidName(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }
            if (name.Length <= 4)
            {
                return false;
            }
            for (int i = 1; i < name.Length; i = i + 1)
            {
                if (!char.IsLetter(name.ElementAt(i)) && name.Contains("([0-9])"))
                {
                    return false;
                }   
            }
            return true;
        }
        public bool isValidMaidenName(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            for (int i = 1; i < name.Length; i = i + 1)
            {
                if (name.Contains("([0-9])"))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isValidJob(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            return true;
        }

        public bool isValidSex(string name)
        {
            if (name == "")
            {
                return false;
            }
            return true;
        }
        public bool isValidBirthDay(string name)
        {
            Console.WriteLine(name);
            if (name != "1945-01-01 ")
            {
                return true;
            }
            return false; 
        }
        public bool isValidIdCard(string name)
        {
            if (name != string.Empty)
            {
                if (char.IsDigit(name.ElementAt(0)))
                {
                    if (char.IsDigit(name.ElementAt(1)))
                    {
                        if (char.IsDigit(name.ElementAt(2)))
                        {
                            if (char.IsDigit(name.ElementAt(3)))
                            {
                                if (char.IsDigit(name.ElementAt(4)))
                                {
                                    if (char.IsDigit(name.ElementAt(5)))
                                    {
                                        if (char.IsLetter(name.ElementAt(6)) && char.IsUpper(name.ElementAt(6)))
                                        {
                                            if (char.IsLetter(name.ElementAt(7)) && char.IsUpper(name.ElementAt(6)))
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
