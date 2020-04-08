using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    public class ModellChildNotValidSexException : Exception
    {
        public ModellChildNotValidSexException()
        {
        }

        public ModellChildNotValidSexException(string message) : base(message)
        {
        }

        public ModellChildNotValidSexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidSexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}