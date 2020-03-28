using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Children
{
    public partial class Child
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT DATE_FORMAT(cbirth,'%Y-%m-%d') AS birth,ID,cname,csex,cidcardnumber,ctajnumber,cbirthplace,DATE_FORMAT(ccoming,'%Y-%m-%d') AS coming,clocation FROM children_fullprofile";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM children_fullprofile";
        }
    }
}
