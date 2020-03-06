using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Parents
{
    public partial class Parent
    {
        public string getInsert()
        {
            return
                "INSERT INTO `parents` (`ID`, `pname`, `pbirth`, `psex`, `pidcardnumber`, `loginpermission`, `loginuser`, `loginpsw`)"
                + "VALUES('"
                + pID
                + "', '"
                + getPname()
                + "', '"
                + getPBirth()
                + "', '" 
                + getPSex()
                + "', '" 
                +getPIdcard()
                + "', '"
                + getPLoginpermission()
                + "', '"
                + getPUser()
                + "', '"
                + getPPassword()
                + "');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `parents` SET `pname`= '"
                + getPname()
                + "', `pbirth` = '"
                + getPBirth()
                + "', `psex` = '"
                + getPBirth()
                + "', `pidcardnumber` = '"
                + getPIdcard()
                + "', `loginpermission` = '"
                + getPLoginpermission()
                + "', `loginuser` = '"
                + getPUser()
                + "', `loginpsw` = '"
                + getPPassword()
                + "' WHERE `parents`.`ID` = "
                + id + ";";
        }
    }
}
