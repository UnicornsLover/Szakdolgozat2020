using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Soul
{
    [Serializable]
    internal class ModellSoulNotValidChildrenNameException : Exception
    {
        public ModellSoulNotValidChildrenNameException()
        {
        }

        public ModellSoulNotValidChildrenNameException(string message) : base(message)
        {
        }

        public ModellSoulNotValidChildrenNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellSoulNotValidChildrenNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}