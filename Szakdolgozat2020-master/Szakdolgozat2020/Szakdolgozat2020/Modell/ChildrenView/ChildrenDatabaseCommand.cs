using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    public partial class ChildrenView
    {

        public string getInsert()
        {
            return
                "INSERT INTO `children_school`(`ID`, `schoolID`, `childrenID`, `fromDate`, `expectedFinish`, `type`, `headteacher`) VALUES('"
                + scID
                + "', '"
                + getSchoolName()
                + "', '"
                + getChildrenName()
                + "', '"
                + getFromDate()
                + "', '"
                + getExDate()
                + "', '"
                + getType()
                + "', '"
                + getHeadteacher()
                + "');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `children_school` SET `schoolID`= '"
                + getSchoolName()
                + "', `childrenID` = '"
                + getChildrenName()
                + "', `fromDate` = '"
                + getFromDate()
                + "', `expectedFinish` = '"
                + getExDate()
                + "', `type` = '"
                + getType()
                + "', `headteacher` = '"
                + getHeadteacher()
                + "' WHERE `children_school`.`ID` = "
                + id + ";";
        }
    }
}
