using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //*************************Set********************
            this.pID = pID;
            this.pname = pname;
            if (psex == "False")
            {
                psex = "férfi";
                this.psex = psex;
            }
            else if (psex == "True")
            {
                psex = "nő";
                this.psex = psex;
            }
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
            this.user = modified.getPLoginpermission();
            this.password = modified.getPUser();

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
    }
}
