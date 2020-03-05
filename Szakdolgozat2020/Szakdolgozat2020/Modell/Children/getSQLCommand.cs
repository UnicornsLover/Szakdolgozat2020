using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Children
{
    public partial class Children
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM children_fullprofile";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM children_fullprofile";
        }
    }
}
