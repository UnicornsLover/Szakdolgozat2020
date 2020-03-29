using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.EventChildren
{
    [Serializable]
    internal class ModellNotValidExceptionEventDate : Exception
    {
        public ModellNotValidExceptionEventDate()
        {
        }

        public ModellNotValidExceptionEventDate(string message) : base(message)
        {
        }

        public ModellNotValidExceptionEventDate(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidExceptionEventDate(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}