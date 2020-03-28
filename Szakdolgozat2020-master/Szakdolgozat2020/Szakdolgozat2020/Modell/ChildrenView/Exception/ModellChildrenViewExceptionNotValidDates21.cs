using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidDates2 : Exception
    {
        public ModellChildrenViewExceptionNotValidDates2()
        {
        }

        public ModellChildrenViewExceptionNotValidDates2(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidDates2(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidDates2(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}