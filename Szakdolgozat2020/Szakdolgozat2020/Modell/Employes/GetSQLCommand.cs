using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Employes
{
    partial class Employe
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM employes_login";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM employes_login";
        }
    }
}
