using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Children
{
    public partial class Child
    {
        public string getInsert()
        {
            return
                "INSERT INTO `children_fullprofile` (`ID`, `cname`, `csex`, `cidcardnumber`, `ctajnumber`, `cbirth`, `cbirthplace`, `ccoming`, `clocation`)"
                +"VALUES ('"
                +cID 
                +"', '"
                +getCcname()
                +"', '"
                +getCsex()
                +"', '"
                +getCidcard()
                +"', '"
                +getCtajNumber()
                +"', '"
                +getCbirthday()
                +"', '"
                +getCbirthdayplace()
                +"', '"
                +getCcoming()
                +"', '"
                +getClocation()
                +"');";
        }

        public string getUpdate(int id)
        {
            return
                "UPDATE `children_fullprofile` SET `cname`= '"
                + getCcname()
                + "', `csex` = '"
                + getCsex()
                + "', `cidcardnumber` = '"
                + getCidcard()
                + "', `ctajnumber` = '"
                + getCtajNumber()
                + "', `cbirth` = '"
                + getCbirthday()
                + "', `cbirthplace` = '"
                + getCbirthdayplace()
                + "', `ccoming` = '"
                + getCcoming()
                + "', `clocation` = '"
                + getClocation()
                + "' WHERE `children_fullprofile`.`ID` = "
                + id + ";";
        }
    }
}
