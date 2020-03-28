using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.School
{
    public partial class School
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM school";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM school";
        }
    }
}
