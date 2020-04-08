using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    public class ModellChildNotValidNameException : Exception
    {
        public ModellChildNotValidNameException()
        {
        }

        public ModellChildNotValidNameException(string message) : base(message)
        {
        }

        public ModellChildNotValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}