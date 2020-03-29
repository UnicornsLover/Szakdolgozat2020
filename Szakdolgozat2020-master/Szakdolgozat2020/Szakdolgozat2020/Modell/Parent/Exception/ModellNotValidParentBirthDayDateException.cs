using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Parents
{
    [Serializable]
    internal class ModellNotValidParentBirthDayDateException : Exception
    {
        public ModellNotValidParentBirthDayDateException()
        {
        }

        public ModellNotValidParentBirthDayDateException(string message) : base(message)
        {
        }

        public ModellNotValidParentBirthDayDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidParentBirthDayDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}