using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidDates : Exception
    {
        public ModellChildrenViewExceptionNotValidDates()
        {
        }

        public ModellChildrenViewExceptionNotValidDates(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidDates(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidDates(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}