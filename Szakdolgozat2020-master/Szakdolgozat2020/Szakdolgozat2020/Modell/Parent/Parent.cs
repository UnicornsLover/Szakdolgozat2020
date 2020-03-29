using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Forms.Administrator;

namespace Szakdolgozat2020.Modell.Parents
{
    public partial class Parent
    {
        private int pID;
        private string pname;
        private string psex;
        private string pbirth;
        private string pidcard;
        private string loginpermission;
        private string user;
        private string password;

        public Parent(int pID, string pname, string psex, string pbirth, string pidcard,  string loginpermission, string user, string password)
        {
            //*************************Valid********************
            if (!isValidName(pname))
            {
                throw new ModellNotValidParentNamee("Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen.Számot ne tartalamzzon.Kérlek próbáld újra!");
            }
            if (!isValidSex(psex))
            {
                throw new ModellParentNotValidSexException("Nem megfelelő 'Neme' mező, kattintson a lefele mutató nyilra 'Neme' mezőnél és a legördülő menő segítségével válasza ki a nemét.");
            }
            if (!isValidBirthDay(pbirth))
            {
                throw new ModellNotValidParentBirthDayDateException("Nem megfelelő 'Születési idő:' mező, kérem állítsa be a felvett személy születési dátumát.");
            }
            if (!isValidIdCard(pidcard))
            {
                throw new MedellNotValidParentIdcardException("Nem megfelelő 'Személyigazolvány szám:' mező. Kérlek figyelj a formátumra. Pl: 123456AB");
            }
            if (!isValidPermission(loginpermission))
            {
                throw new MedellNotValidParentLoginPerException("Nem megfelelő 'Engedély mező, kérem töltse ki. Kötelző.'");
            }
            //*************************Set********************
            this.pID = pID;
            this.pname = pname;
            this.psex = psex;
            this.pbirth = pbirth;
            this.pidcard = pidcard;
            this.loginpermission = loginpermission;
            this.user = user;
            this.password = password;
        }
        public void updateL(Parent modified)
        {
            this.pname = modified.getPname();
            this.psex = modified.getPSex();
            this.pbirth = modified.getPBirth();
            this.pidcard = modified.getPIdcard();
            this.loginpermission = modified.getPLoginpermission();
            this.user = modified.getPUser();
            this.password = modified.getPPassword();

        }
        //*****************************Setter*****************************
        public void setpID(int pID)
        {
            this.pID = pID;
        }
        public void setPname(string pname)
        {
            this.pname = pname;
        }
        public void setPSex(string psex)
        {
            this.psex = psex;
        }
        public void setPBirth(string pbirth)
        {
            this.pbirth = pbirth;
        }
        public void setPIdcard(string pidcard)
        {
            this.pidcard = pidcard;
        }

        public void setPLoginpermission(string loginpermission)
        {
            this.loginpermission = loginpermission;
        }
        public void setPUser(string user)
        {
            this.user = user;
        }
        public void setPPassword(string password)
        {
            this.password = password;
        }
        //********************************Getter*********************************-
        public int getPID()
        {
            return pID;
        }
        public string getPname()
        {
            return pname;
        }
        public string getPSex()
        {
            return psex;
        }
        public string getPBirth()
        {
            return pbirth;
        }
        public string getPIdcard()
        {
            return pidcard;
        }
        public string getPLoginpermission()
        {
            return loginpermission;
        }
        public string getPPassword()
        {
            return password;
        }
        public string getPUser()
        {
            return user;
        }
        //****************************Validation*************************
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
        public bool isValidPermission(string name)
        {
            if (name == "")
            {
                return false;
            }
            return true;
        }
        public bool isValidBirthDay(string name)
        {
            if (name != "1950-01-01")
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
