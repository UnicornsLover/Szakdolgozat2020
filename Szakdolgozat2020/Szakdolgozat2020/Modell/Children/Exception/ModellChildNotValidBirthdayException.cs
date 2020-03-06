using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    internal class ModellChildNotValidBirthdayException : Exception
    {
        public ModellChildNotValidBirthdayException()
        {
        }

        public ModellChildNotValidBirthdayException(string message) : base(message)
        {
        }

        public ModellChildNotValidBirthdayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidBirthdayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}