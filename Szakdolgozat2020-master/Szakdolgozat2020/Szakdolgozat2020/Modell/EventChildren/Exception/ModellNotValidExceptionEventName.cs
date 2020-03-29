using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.EventChildren
{
    [Serializable]
    internal class ModellNotValidExceptionEventName : Exception
    {
        public ModellNotValidExceptionEventName()
        {
        }

        public ModellNotValidExceptionEventName(string message) : base(message)
        {
        }

        public ModellNotValidExceptionEventName(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidExceptionEventName(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}