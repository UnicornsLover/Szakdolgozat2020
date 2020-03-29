using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.EventChildren
{
    public partial class EventChild
    {
        public string getInsert()
        {
            return
                "INSERT INTO `ceventsk` (`ID`, `childrenID`, `eventsID`, `timer`)"
                + "VALUES('"
                + ecID
                + "', '"
                + getChildrenName()
                + "', '"
                + getEventName()
                + "', '"
                + getDateTime()
                + "');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `ceventsk` SET `childrenID`= '"
                + getChildrenName()
                + "', `eventsID` = '"
                + getEventName()
                + "', `timer` = '"
                + getDateTime()
                + "' WHERE `ceventsk`.`ID` = "
                + id + ";";
        }

    }
}
