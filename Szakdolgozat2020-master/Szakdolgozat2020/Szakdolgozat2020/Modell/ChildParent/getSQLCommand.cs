using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.ChildParent
{
    public partial class ChildParent
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT parentsk.ID, children_fullprofile.cname, parents.pname FROM children_fullprofile INNER JOIN parentsk ON children_fullprofile.ID = parentsk.childrenID INNER JOIN parents ON parentsk.pID = parents.ID";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM parentsk";
        }

    }
}
