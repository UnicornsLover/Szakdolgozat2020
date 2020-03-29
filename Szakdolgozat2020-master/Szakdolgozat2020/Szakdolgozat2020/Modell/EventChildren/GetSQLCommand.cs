using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.EventChildren
{
    public partial class EventChild
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT ceventsk.ID, children_fullprofile.cname,children_events.title,DATE_FORMAT(timer,'%Y-%m-%d') AS timer FROM `ceventsk` INNER JOIN children_fullprofile ON  children_fullprofile.ID = ceventsk.childrenID INNER JOIN children_events ON ceventsk.eventsID = children_events.ID";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM ceventsk";
        }

    }
}
