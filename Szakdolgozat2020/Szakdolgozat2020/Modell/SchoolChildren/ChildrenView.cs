using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    class ChildrenView
    {
        private string name;

        public ChildrenView(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
