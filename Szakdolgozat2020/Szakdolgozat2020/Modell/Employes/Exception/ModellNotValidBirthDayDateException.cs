using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellNotValidBirthDayDateException : Exception
    {
        public ModellNotValidBirthDayDateException()
        {
        }

        public ModellNotValidBirthDayDateException(string message) : base(message)
        {
        }

        public ModellNotValidBirthDayDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidBirthDayDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}