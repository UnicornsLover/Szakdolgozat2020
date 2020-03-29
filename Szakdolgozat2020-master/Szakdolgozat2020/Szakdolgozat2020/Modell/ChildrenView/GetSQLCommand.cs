using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    public partial class ChildrenView
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT children_school.ID, school.schoolName, children_fullprofile.cname, DATE_FORMAT(fromDate ,'%Y-%m-%d') AS fromDate,DATE_FORMAT(expectedFinish ,'%Y-%m-%d') AS expectedFinish, type, headteacher " +
                "FROM children_school Inner JOIN school On children_school.schoolID = school.ID INNER join children_fullprofile On children_school.childrenID = children_fullprofile.ID ;";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM children_school";
        }
    }
}
