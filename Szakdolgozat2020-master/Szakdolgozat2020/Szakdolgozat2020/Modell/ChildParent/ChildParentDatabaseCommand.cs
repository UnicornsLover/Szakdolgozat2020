using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.ChildParent
{
    public partial class ChildParent
    {
        public string getInsert()
        {
            return
                "INSERT INTO `parentsk` (`ID`, `pID`, `childrenID`)"
                + "VALUES ('"
                + cpID
                + "', '"
                + getParentname()
                + "', '"
                + getChildName()
                + "');";
        }

        public string getUpdate(int id)
        {
            return
                "UPDATE `parentsk` SET `pID`= '"
                + getParentname()
                + "', `childrenID` = '"
                + getChildName()
                + "' WHERE `parentsk`.`ID` = "
                + id + ";";
        }
    }
}
