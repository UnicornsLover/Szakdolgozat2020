using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.School
{
    public partial class School
    {
        public string getInsert()
        {
            return
                "INSERT INTO `school` (`ID`, `schoolName`, `schoolLocation`, `schoolPhone`)"
                + "VALUES('"
                + sID
                + "', '"
                + getName()
                + "', '"
                + getLocation()
                + "', '"
                + getPhone()
                + "');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `school` SET `schoolName`= '"
                + getName()
                + "', `schoolLocation` = '"
                + getLocation()
                + "', `schoolPhone` = '"
                + getPhone()
                + "' WHERE `parents`.`ID` = "
                + id + ";";
        }

    }
}
