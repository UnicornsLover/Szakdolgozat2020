using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    internal class ModellChildNotValidLocationException : Exception
    {
        public ModellChildNotValidLocationException()
        {
        }

        public ModellChildNotValidLocationException(string message) : base(message)
        {
        }

        public ModellChildNotValidLocationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}