using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidDates3 : Exception
    {
        public ModellChildrenViewExceptionNotValidDates3()
        {
        }

        public ModellChildrenViewExceptionNotValidDates3(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidDates3(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidDates3(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}