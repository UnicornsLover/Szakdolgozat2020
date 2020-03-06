using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    internal class ModellChildNotValidComingException : Exception
    {
        public ModellChildNotValidComingException()
        {
        }

        public ModellChildNotValidComingException(string message) : base(message)
        {
        }

        public ModellChildNotValidComingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidComingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}