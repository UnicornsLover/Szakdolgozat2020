using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Children
{
    public partial class Child
    {
        private int cID;
        private string cname;
        private string csex;
        private string cidcard;
        private string ctajnumber;
        private string cbirthday;
        private string cbirthdayplace;
        private string ccomming;
        private string clocation;

        public Child(int cID, string cname, string csex, string cidcard, string ctajnumber, string cbirthday, string cbirthdayplace, string ccomming, string clocation)
        {
            if (!isValidName(cname))
            {
                throw new ModellChildNotValidNameException("Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen. Számot ne tartalamzzon. Kérlek próbáld újra!");
            }
            if (!isValidSex(csex))
            {
                throw new ModellChildNotValidSexException("Nem megfelelő 'Neme' mező, kattintson a lefele mutató nyilra 'Neme' mezőnél és a legördülő menő segítségével válasza ki a nemet.");
            }
            if (!isValidIdCard(cidcard))
            {
                throw new MedellNotValidChiIdcardException("Nem megfelelő 'Személyigazolvány szám:' mező. Kérlek figyelj a formátumra. Pl: 123456AB");
            }
            if (!isValidTaj(ctajnumber))
            {
                throw new ModellChildNotValidTajnumberException("Nem megfelelő 'Taj szam:' mező. Kérlek figyelj oda a formátumra, csak számot tartalmazhat. pl:123456789");
            }
            if (!isValidBirthDay(cbirthday))
            {
                throw new ModellChildNotValidBirthdayException("Nem megfelelő 'Születési idő:' mező, kérem állítsa be a felvett személy születési dátumát!");
            }
            if (!isValidBirthPlace(cbirthdayplace))
            {
                throw new ModellChildNotValidBirthplaceException("Nem megfelelő 'Születési hely' mező, kezdje nagy betűvel a város nevet. Kérem próbálja újra.");
            }
            if (!isValidComing(ccomming))
            {
                throw new ModellChildNotValidComingException("Nem megfelelő 'Belépés időpontja:' mező, kérem állítsa be a felvett személy belépési dátumát!");
            }
            if (!isValidLocation(clocation))
            {
                throw new ModellChildNotValidLocationException("Nem megfelelő 'Intézmény helye, ahol tartózkodik:' mező. Kezdje nagy betűvel a város nevét, irányitó számot ne írjon. Kérem próbálja újra.");
            }
            
            //***********Set************
            this.cID = cID;
            this.cname = cname;
            if (csex == "False")
            {
                csex = "férfi";
                this.csex = csex;
            }
            else if (csex == "True")
            {
                csex = "nő";
                this.csex = csex;
            }
            this.cidcard = cidcard;
            this.ctajnumber = ctajnumber;
            this.cbirthday = cbirthday;
            this.cbirthdayplace = cbirthdayplace;
            this.ccomming = ccomming;
            this.clocation = clocation;
        }

        public void updateL(Child modified)
        {
            this.cname = modified.getCname();
            this.csex = modified.getCsex();
            this.cidcard = modified.getCidcard();
            this.ctajnumber = modified.getCtajNumber();
            this.cbirthday = modified.getCbirthday();
            this.cbirthdayplace = modified.getCbirthdayplace();
            this.ccomming = modified.getCcoming();
            this.clocation = modified.getClocation();
        }
        //******************************************GETTER***************************************
        public int getCID()
        {
            return cID;
        }
        public string getCsex()
        {
            return csex;
        }
        public string getCname()
        {
            return cname;
        }
        public string getCidcard()
        {
            return cidcard;
        }
        public string getCtajNumber()
        {
            return ctajnumber;
        }
        public string getCbirthday()
        {
            return cbirthday;
        }
        public string getCbirthdayplace()
        {
            return cbirthdayplace;
        }
        public string getCcoming()
        {
            return ccomming;
        }
        public string getClocation()
        {
            return clocation;
        }
        //******************************************SETTER***************************************
        public void setCID(int id)
        {
            this.cID = id;
        }
        public void setCName(string name)
        {
            this.cname = name;
        }
        public void setCSex(string csex)
        {
            this.csex = csex;
        }
        public void setCidcard(string cidcard)
        {
            this.cidcard = cidcard;

        }
        public void setCtajNumber(string ctajnumber)
        {
            this.ctajnumber = ctajnumber;
        }
        public void setCbirthday(string ctajnumber)
        {
            this.ctajnumber = ctajnumber;
        }
        public void setCBirth(string cbirthday)
        {
            this.cbirthday = cbirthday;
        }
        public void setCBPlace(string cbirthdayplace)
        {
            this.cbirthdayplace = cbirthdayplace;
        }
        public void setCcoming(string ccomming)
        {
            this.ccomming = ccomming;
        }
        public void setCLocation(string clocation)
        {
            this.clocation = clocation;
        }

        //****************************************************Validation****************************
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
            if (name != "1990-01-01")
            {
                return true;
            }
            return false;
        }
        public bool isValidComing(string name)
        {
            if (name != "1990-01-01")
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

        public bool isValidTaj(string name)
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
                                        if (char.IsDigit(name.ElementAt(6)))
                                        {
                                            if (char.IsDigit(name.ElementAt(7)))
                                            {
                                                if (char.IsDigit(name.ElementAt(8)))
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
            else
            {
                return false;
            }
            
            
        }
    }
}
