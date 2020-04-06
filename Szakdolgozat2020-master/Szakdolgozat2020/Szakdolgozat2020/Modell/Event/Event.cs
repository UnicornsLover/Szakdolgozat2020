using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Event
{
    public partial class Event
    {
        private int eID;
        private string title;
        private string details;
        private string byy;

        public Event(int eID, string title, string details, string byy)
        {
            if (isValidTextBox(title))
            {
                throw new ModellNotValidEventTitle("Töltse ki a 'Cím' mezőt!");
            }
            if (isValidTextBox(details))
            {
                throw new ModellNotValidEventDetails("Töltse ki a 'Leírás' mezőt!");
            }

            this.eID = eID;
            this.title = title;
            this.details = details;
            this.byy = byy;
        }
        public void updateL(Event modified)
        {
            this.eID = modified.getEID();
            this.title = modified.getTitle();
            this.details = modified.getDetails();
            this.byy = modified.getBy();
        }
        //****************************Setter*************************
        public void seteID(int eID)
        {
            this.eID = eID;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setDetails(string details)
        {
            this.details = details;
        }
        
        public void setBy(string byy)
        {
            this.byy = byy;
        }

        //****************************Getter*************************
        public int getEID()
        {
            return eID;
        }
        public string getTitle()
        {
            return title;
        }
        public string getDetails()
        {
            return details;
        }
        public string getBy()
        {
            return byy;
        }

        //****************************Validation*************************
        public bool isValidTextBox(string name)
        {
            if (name == string.Empty)
            {
                return true;
            }
            return false;
        }

    }   
}
