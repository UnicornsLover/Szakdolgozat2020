using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Soul
{
    [Serializable]
    internal class ModellSoulNotValidTypeException : Exception
    {
        public ModellSoulNotValidTypeException()
        {
        }

        public ModellSoulNotValidTypeException(string message) : base(message)
        {
        }

        public ModellSoulNotValidTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellSoulNotValidTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}