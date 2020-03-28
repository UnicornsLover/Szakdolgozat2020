using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Modell.Children;
using Szakdolgozat2020.Modell.School;
using Szakdolgozat2020.Modell.SchoolChildren;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    public partial class ChildrenViews
    {
        public ChildrenViews()
        {
            childrenviews = new List<ChildrenView>();
        }
    }
}
