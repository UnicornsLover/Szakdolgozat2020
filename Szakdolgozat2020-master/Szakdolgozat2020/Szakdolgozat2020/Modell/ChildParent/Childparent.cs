using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.ChildParent
{
    public partial class ChildParent
    {
        private int cpID;
        private string childrenName;
        private string parentName;

        public ChildParent(int cpID, string parentName, string childrenName)
        {
            
            if (!isValidCombo(childrenName))
            {
                throw new ModellExceptionNotValidPArentName("Válasza ki a szülő nevét!");
            }
            if (!isValidCombo(parentName))
            {
                throw new ModellExceptionNotValidChildrenName("Válasza ki a gyerek nevét!");
            }
            this.cpID = cpID;
            this.childrenName = childrenName;
            this.parentName = parentName;
        }
        public void updateL(ChildParent modified)
        {
            this.cpID = modified.getCpID();
            this.childrenName = modified.getChildName();
            this.parentName = modified.getParentname();
        }
        public int getCpID()
        {
            return cpID;
        }
        public string getChildName()
        {
            return childrenName;
        }
        public string getParentname()
        {
            return parentName;
        }
        public void setcpID(int cpID)
        {
            this.cpID = cpID;
        }
        public void setChildName(string childrenName)
        {
            this.childrenName = childrenName;
        }
        public void setCSex(string parentName)
        {
            this.parentName = parentName;
        }
        public bool isValidCombo(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            return true;
        }

    }
}
