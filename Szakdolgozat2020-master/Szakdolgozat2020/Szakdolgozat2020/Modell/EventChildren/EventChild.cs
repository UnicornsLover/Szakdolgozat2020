using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.EventChildren
{
    public partial class EventChild
    {
        private int ecID;
        private string childrenName;
        private string eventName;
        private string dateTime;

        public EventChild(int ecID, string childrenName, string eventName, string dateTime)
        {
            if (!isValidName(childrenName))
            {
                throw new ModellNotValidExceptionChildrenName("Válassza ki a kivánt gyereket a legördülő opciók közül! (Gyermek neve:)");
            }
            if (!isValidName(eventName))
            {
                throw new ModellNotValidExceptionEventName("Válassza ki a kivánt eseményt a legördülő opciók közül! (Esemény neve:)");
            }
            if (!isValidDate(dateTime))
            {
                throw new ModellNotValidExceptionEventDate("Állítson be az eseményre egy dátumot! (Esemény ideje:)");
            }

            this.ecID = ecID;
            this.childrenName = childrenName;
            this.eventName = eventName;
            this.dateTime = dateTime;
        }
        public void updateL(EventChild modified)
        {
            this.ecID = modified.getecID();
            this.childrenName = modified.getChildrenName();
            this.eventName = modified.getEventName();
            this.dateTime = modified.getDateTime();


        }
        //****************************Settter*************************
        public void setecID(int ecID)
        {
            this.ecID = ecID;
        }
        public void setCname(string childrenName)
        {
            this.childrenName = childrenName;
        }
        public void setEventName(string eventName)
        {
            this.eventName = eventName;
        }
        public void setDateTime(string dateTime)
        {
            this.dateTime = dateTime;
        }
        //****************************Getter*************************
        public int getecID()
        {
            return ecID;
        }
        public string getChildrenName()
        {
            return childrenName;
        }
        public string getEventName()
        {
            return eventName;
        }
        public string getDateTime()
        {
            return dateTime;
        }

        //****************************Validation*************************
        public bool isValidName(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            return true;
        }
        public bool isValidDate(string name)
        {
            if (name == "1990-01-01")
            {
                return false;
            }
            return true;
        }

    }
}
