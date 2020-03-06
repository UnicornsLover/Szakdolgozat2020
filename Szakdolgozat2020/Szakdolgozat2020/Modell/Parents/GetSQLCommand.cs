using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Parents
{
    public partial class Parent
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM parents";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM parents";
        }
    }
}
