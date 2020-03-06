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
                "INSERT INTO `employes_login` (`ID`, `ename`, `emaidenname`, `esex`, `ebirth`, `ebirthplace`, `ejob`, `elocation`,`idcard`, `euname`, `epassword`)"
                + "VALUES('"
                + eID
                + "', '"
                + getEname()
                + "', '"
                + getEmaidenname()
                + "', '" +
                getEsex()
                + "', '" +
                getEallbirthday()
                + "', '"
                + getEbirthplace()
                + "', '"
                + getEjob()
                + "', '"
                + getElocation()
                + "', '"
                + getIdcard()
                + "', '"
                + getEuname()
                +"', '"
                +getEpasword()
                +"');";
        }
        public string getUpdate(int id)
        {
            return
                "UPDATE `employes_login` SET `ename`= '"
                + getEname()
                + "', `emaidenname` = '"
                + getEmaidenname()
                + "', `esex` = '"
                + getEsex()
                + "', `ebirth` = '"
                + getEallbirthday()
                + "', `ebirthplace` = '"
                + getEbirthplace()
                + "', `ejob` = '"
                + getEjob()
                + "', `elocation` = '"
                + getElocation()
                + "', `euname` = '"
                + getEuname()
                + "', `epassword` = '"
                + getEpasword()
                + "' WHERE `employes_login`.`ID` = "
                + id + ";";
        }
    }
}
