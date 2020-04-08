using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    public class ModellChildNotValidTajnumberException : Exception
    {
        public ModellChildNotValidTajnumberException()
        {
        }

        public ModellChildNotValidTajnumberException(string message) : base(message)
        {
        }

        public ModellChildNotValidTajnumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidTajnumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}