using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Employes
{
    partial class Employe
    {
        public string getInsert()
        {
            return
                "INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`, `euname`, `epassword`)"
                +"VALUES(NULL, '', '', '', '', '', '', '', '', '');";
        }
        public string getUpdate(int id)
        {
            return null;
        }
        public string getAllRecordCommand()
        {
            return "SELECT * FROM employes_login";
        }
    }
}
