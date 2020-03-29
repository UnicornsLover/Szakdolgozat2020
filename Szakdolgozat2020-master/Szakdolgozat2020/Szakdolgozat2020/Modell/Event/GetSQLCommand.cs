using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Event
{
    public partial class Event
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM children_events";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM children_events";
        }
    }   
}
