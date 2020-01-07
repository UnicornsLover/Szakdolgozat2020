using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Database
{
    /// <summary>
    /// Database-hez csatlakozó metódusok
    /// </summary>
    class Connection
    {
        public string getCreateConnectionString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
        public string getConnectionString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"liveincare\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }



    }
}
