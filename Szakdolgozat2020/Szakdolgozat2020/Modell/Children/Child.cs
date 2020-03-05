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


    }
}
