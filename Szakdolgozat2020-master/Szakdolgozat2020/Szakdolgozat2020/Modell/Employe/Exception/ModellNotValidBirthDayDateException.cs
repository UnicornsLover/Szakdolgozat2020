using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellNotValidEmployeBirthDayDateException : Exception
    {
        public ModellNotValidEmployeBirthDayDateException()
        {
        }

        public ModellNotValidEmployeBirthDayDateException(string message) : base(message)
        {
        }

        public ModellNotValidEmployeBirthDayDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidEmployeBirthDayDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}