using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Employes
{
    public partial class Employe
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT DATE_FORMAT(ebirth ,'%Y-%m-%d') AS birth,ID,ename,emaidenname,esex,ebirthplace,ejob,elocation,idcard,euname,epassword  FROM employes_login";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM employes_login";
        }
    }
}
