using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    public partial class ChildrenView
    {
        private int scID;
        private string name;
        private string schoolname;
        private string fromDate;
        private string exDate;
        private string type;
        private string hteacher;

        public ChildrenView(int scID, string schoolname, string name, string fromDate, string exDate, string type, string hteacher)
        {
            if (!isValidBAndF(fromDate, exDate))
            {
                throw new ModellChildrenViewExceptionNotValidDates("A kezdés dátuma nem lehet később mint a befejezés dátuma!");
            }
            else if (!isValidDate(fromDate))
            {
                throw new ModellChildrenViewExceptionNotValidDates2("Válaszon ki egy dátumot!");
            }
            else if (!isValidDate(exDate))
            {
                throw new ModellChildrenViewExceptionNotValidDates3("Válaszon ki egy dátumot!");
            }
            if (isValidCNAmeEmpty(schoolname))
            {
                throw new ModellChildrenViewExceptionNotValidSchool("Válaszon ki egy intézmény a legördülő menüből!");
            }
            if (isValidCNAmeEmpty(name))
            {
                throw new ModellChildrenViewExceptionNotValidChildren("Válaszon ki egy gyereket a legördülő menüből!");
            }
            if(isValidEmpty(type))
            {
                throw new ModellChildrenViewExceptionNotValidType("Írja be az iskolában tanult tipust (pl: Átalános, Emelt biólógia, Pincér)! Kezdje nagy betűvel!");
            }
            if (isValidEmpty(hteacher))
            {
                throw new ModellChildrenViewExceptionNotValidHteacher("Írja be az osztályfönők nevét! Kezdje nagy betűvel!"); 
            }
            this.scID = scID;
            this.name = name;
            this.schoolname = schoolname;
            this.fromDate = fromDate;
            this.exDate = exDate;
            this.type = type;
            this.hteacher = hteacher;
        }

        public void updateL(ChildrenView modified)
        {
            this.scID = modified.getscID();
            this.schoolname = modified.getSchoolName();
            this.name = modified.getChildrenName();
            this.fromDate = modified.getFromDate();
            this.exDate = modified.getExDate();
            this.type = modified.getType();
            this.hteacher = modified.getHeadteacher();
        }
        public void setscID(int scID)
        {
            this.scID = scID;
        }
        public void setChildrenName(string name)
        {
            this.name = name;
        }
        public void setSchoolName(string schoolname)
        {
            this.schoolname = schoolname;
        }
        public void setFromDate(string fromDate)
        {
            this.fromDate = fromDate;
        }
        public void setExDate(string exDate)
        {
            this.exDate = exDate;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setHeadTeacher(string hteacher)
        {
            this.hteacher = hteacher;
        }

        public int getscID()
        {
            return scID;
        }
        public string getChildrenName()
        {
            return name;
        }
        public string getSchoolName()
        {
            return schoolname;
        }
        public string getFromDate()
        {
            return fromDate;
        }
        public string getExDate()
        {
            return exDate;
        }
        public string getType()
        {
            return type;
        }
        public string getHeadteacher()
        {
            return hteacher;
        }

        //****************************************Vlaidation************************************************
        public bool isValidEmpty(string adat)
        {
            if (name == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }
            
            return true;
        }
        public bool isValidCNAmeEmpty(string adat)
        {
            if (adat == "")
            {
                return false;
            }

            return true;
        }

        public bool isValidBAndF(string start, string finish)
        {
            DateTime dateTime1 = DateTime.Parse(start);
            DateTime dateTime2 = DateTime.Parse(finish);
            if (dateTime1 < dateTime2)
            {
                return false;
            }
            return true;
        }

        public bool isValidDate(string adat)
        {
            if (adat != "1990-01-01")
            {
                return true;
            }
            return false;
        }
    }
}
