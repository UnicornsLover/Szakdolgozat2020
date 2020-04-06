using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Event
{
    [Serializable]
    internal class ModellEventNotValidException : Exception
    {
        public ModellEventNotValidException()
        {
        }

        public ModellEventNotValidException(string message) : base(message)
        {
        }

        public ModellEventNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEventNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}