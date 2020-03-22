using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szakdolgozat2020.Modell.Children;
using Szakdolgozat2020.Modell.School;
using Szakdolgozat2020.Modell.SchoolChildren;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    class ChildrenViews
    {
        List<ChildrenView> childrenviews;
        public ChildrenViews(int schoolId, List<Child> children,List<School> schools)
        {
            childrenviews = new List<ChildrenView>();
            List<School> s = schools.FindAll(x=>x.getSID()== schoolId);
            
        }
    }
}
