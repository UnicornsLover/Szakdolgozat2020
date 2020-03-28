using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Soul
{
    [Serializable]
    internal class ModellSoulNotValidDetailsException : Exception
    {
        public ModellSoulNotValidDetailsException()
        {
        }

        public ModellSoulNotValidDetailsException(string message) : base(message)
        {
        }

        public ModellSoulNotValidDetailsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellSoulNotValidDetailsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}