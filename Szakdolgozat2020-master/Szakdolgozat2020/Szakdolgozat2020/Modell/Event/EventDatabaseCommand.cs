using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Event
{
    public partial class Event
    {
        public string getInsert()
        {
            return
                "INSERT INTO `children_events` (`ID`, `title`, `details`, `by`)"
                + "VALUES('"
                + eID
                + "', '"
                + getTitle()
                + "', '"
                + getDetails()
                + "', '"
                + getBy()
                + "');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `children_events` SET `title`= '"
                + getTitle()
                + "', `details` = '"
                + getDetails()
                + "', `by` = '"
                + getBy()
                + "' WHERE `children_events`.`ID` = "
                + id + ";";
        }
    }   
}
