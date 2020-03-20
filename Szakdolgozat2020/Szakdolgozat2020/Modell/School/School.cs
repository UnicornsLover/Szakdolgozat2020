using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.School
{
    public partial class School
    {
        private int sID;
        private string sName;
        private string sLocation;
        private string sPhone;

        public School(int sID, string sName, string sLocation, string sPhone)
        {
            if (!isValidName(sName))
            {
                throw new ModellNotValidSchoolNameException("");
            }
            if (!isValidLocation(sLocation))
            {
                throw new ModellNotValidSchoolLocationException("");
            }
            if (!isValidPhone(sPhone))
            {
                throw new ModellNotValidSchoolphoneException("");
            }
            //*************************Set********************
            this.sID = sID;
            this.sName = sName;
            this.sLocation = sLocation;
            this.sPhone = sPhone;
        }

        public void updateL(School modified)
        {
            this.sID = modified.getSID();
            this.sName = modified.getName();
            this.sLocation = modified.getLocation();
            this.sPhone = modified.getPhone();
        }

        //*****************************Setter*****************************
        public void setsID(int sID)
        {
            this.sID = sID;
        }
        public void setName(string sName)
        {
            this.sName = sName;
        }
        public void setLocation(string sLocation)
        {
            this.sLocation = sLocation;
        }
        public void setPhone(string sPhone)
        {
            this.sPhone = sPhone;
        }
        //********************************Getter*********************************-
        public int getSID()
        {
            return sID;
        }
        public string getName()
        {
            return sName;
        }
        public string getLocation()
        {
            return sLocation;
        }
        public string getPhone()
        {
            return sPhone;
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
            if (name.Length <= 10)
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

        public bool isValidPhone(string phone)
        {
            if (phone != string.Empty && phone.Length == 10)
            {
                if (char.IsDigit(phone.ElementAt(0)) && phone.ElementAt(0).Equals('0'))
                {
                    if (char.IsDigit(phone.ElementAt(1)) && phone.ElementAt(1).Equals('6'))
                    {
                        if (char.IsDigit(phone.ElementAt(2)) && phone.ElementAt(2).Equals('7'))
                        {
                            if (char.IsDigit(phone.ElementAt(3)) && phone.ElementAt(3).Equals('6'))
                            {
                                if (char.IsDigit(phone.ElementAt(4)))
                                {
                                    if (char.IsDigit(phone.ElementAt(5)))
                                    {
                                        if (char.IsDigit(phone.ElementAt(6)))
                                        {
                                            if (char.IsDigit(phone.ElementAt(7)))
                                            {
                                                if (char.IsDigit(phone.ElementAt(8)))
                                                {
                                                    if (char.IsDigit(phone.ElementAt(9)))
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
            else
            {
                return false;
            }
        }
    }
}
