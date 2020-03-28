using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Soul
{
    [Serializable]
    internal class ModellSoulNotValidDateException : Exception
    {
        public ModellSoulNotValidDateException()
        {
        }

        public ModellSoulNotValidDateException(string message) : base(message)
        {
        }

        public ModellSoulNotValidDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellSoulNotValidDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}