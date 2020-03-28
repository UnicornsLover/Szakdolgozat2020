using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Soul
{
    public partial class SoulM
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT children_healths.boardID,children_fullprofile.cname,children_healths.type,children_healths.details,children_healths.special_treatment,children_healths.treatdate,children_healths.by " +
                "FROM children_fullprofile INNER JOIN children_healths ON children_fullprofile.ID = children_healths.childrenID";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM children_healths";
        }
    }
}
