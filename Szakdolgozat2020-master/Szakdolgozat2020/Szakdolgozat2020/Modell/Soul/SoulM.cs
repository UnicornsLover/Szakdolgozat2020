using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Soul
{
    public partial class SoulM
    {
        private int sID;
        private string cName;
        private string type;
        private string details;
        private string specialt;
        private string treatdate;
        private string byname;

        public SoulM(int sID, string cName, string type, string details, string specialt, string treatdate, string byname)
        {
            if (!isValidCNAmeEmpty(cName))
            {
                throw new ModellSoulNotValidChildrenNameException("Üres a 'Gyermek neve' mező! Válaszon ki egy nevet a legördülő menüből! Kötelező megadni.");
            }
            if (!isValidEmpty(type))
            {
                throw new ModellSoulNotValidTypeException("Üres a 'Tipus' mező! Adja meg az tanulmány tipusát az adott intézményben. Nagy betűvel kezdje. Kötelező megadni.");
            }
            if (!isValidEmpty(details))
            {
                throw new ModellSoulNotValidDetailsException("Üres a 'Leírás' mező! Adja meg a viizsgálat leírását. Kezdje nagy betűvel a mondatot. Kötelező megadni.");
            }
            if (!isValidEmpty(specialt))
            {
                throw new ModellSoulNotValidSpecaialTreatmentException("Üres a 'Különleges ellátás' mező! Adja meg, ha igényel a gyerek valami különleges bánás módot. Nagy betűvel kezdej a mondtot/ szót. Kötelező megadni. Ha nem akkor írja oda hogy 'Nem igányel' .");
            }
            if (!isValidDate(treatdate))
            {
                throw new ModellSoulNotValidDateException("Üres a 'Felvett dátuma' mező! Adja meg a felvett vizsgálat dátumát. Ami eltér '1990-01-01'-től");
            }

            this.sID = sID;
            this.cName = cName;
            this.type = type;
            this.details = details;
            this.specialt = specialt;
            this.treatdate = treatdate;
            this.byname = byname;
        }

        public void setsID(int sID)
        {
            this.sID = sID;
        }
        public void setCname(string cName)
        {
            this.cName = cName;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setDetails(string details)
        {
            this.details = details;
        }
        public void setSpecial(string specialt)
        {
            this.specialt = specialt;
        }
        public void setTreat(string treatdate)
        {
            this.treatdate = treatdate;
        }
        public void setby(string byname)
        {
            this.byname = byname;
        }

        public int getSID()
        {
            return sID;
        }
        public string getCname()
        {
            return cName;
        }
        public string getType()
        {
            return type;
        }
        public string getDetails()
        {
            return details;
        }
        public string getSpecialT()
        {
            return specialt;

        }
        public string getTreatDate()
        {
            return treatdate;
        }
        public string getByname()
        {
            return byname;
        }

        public void updateL(SoulM modified)
        {
            this.sID = modified.getSID();
            this.cName = modified.getCname();
            this.type = modified.getType();
            this.details = modified.getDetails();
            this.specialt = modified.getSpecialT();
            this.treatdate = modified.getTreatDate();
            this.byname = modified.getByname();
        }
        //*******************************alid***************************-
        public bool isValidCNAmeEmpty(string adat)
        {
            if (adat == "")
            {
                return false;
            }

            return true;
        }
        public bool isValidEmpty(string adat)
        {
            if (adat == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(adat.ElementAt(0)))
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
