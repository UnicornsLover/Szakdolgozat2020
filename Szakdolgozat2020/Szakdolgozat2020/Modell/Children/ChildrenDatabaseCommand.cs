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
                "INSERT INTO `childen_fullprofile` (`ID`, `cname`, `csex`, `cidcardnumber`, `ctajnumber`, `cbirthday`, `cbirthdplace`, `ccoming`, `clocation`)"
                +"VALUES ('"
                +cID 
                +"', '"
                +getCname()
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
                +"')";
        }

        public string getUpdate(int id)
        {
            return
                "UPDATE `childen_fullprofile` SET `cname`= '"
                + getCname()
                + "', `csex` = '"
                + getCsex()
                + "', `cidcardnumber` = '"
                + getCidcard()
                + "', `ctajnumber` = '"
                + getCtajNumber()
                + "', `cbirthday` = '"
                + getCbirthday()
                + "', `cbirthdplace` = '"
                + getCbirthdayplace()
                + "', `ccoming` = '"
                + getCcoming()
                + "', `clocation` = '"
                + getClocation()
                + "' WHERE `childen_fullprofile`.`ID` = "
                + id + ";";
        }
    }
}
