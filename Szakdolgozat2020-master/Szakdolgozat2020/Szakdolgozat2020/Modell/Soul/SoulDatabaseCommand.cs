using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Soul
{
    public partial class SoulM
    {
       public string getInsert()
       {
            return "INSERT INTO `children_healths`(`boardID`, `childrenID`, `type`, `details`, `special_treatment`, `treatdate`, `by`) " +
                "VALUES('"
                + sID
                + "', '"
                + getCname()
                + "', '"
                +getType()
                + "', '"
                +getDetails()
                + "', '"
                +getSpecialT()
                + "', '"
                +getTreatDate()
                + "', '"
                +getByname()
                +"');";
       }

        public string getUpdate(int id)
        { 
            return
                "UPDATE `children_healths` SET `childrenID`= '"
                + getCname()
                + "', `type` = '"
                + getType()
                + "', `details` = '"
                + getDetails()
                + "', `special_treatment` = '"
                + getSpecialT()
                + "', `treatdate` = '"
                + getTreatDate()
                + "', `by` = '"
                + getByname()
                + "' WHERE `children_healths`.`boardID` = "
                + id + ";";
        }
    }
}
