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
            return "SELECT DATE_FORMAT(pbirth,'%Y-%m-%d') AS birth, ID, pname,psex,pidcardnumber,loginpermission,loginuser,loginpsw FROM parents";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM parents";
        }
    }
}
