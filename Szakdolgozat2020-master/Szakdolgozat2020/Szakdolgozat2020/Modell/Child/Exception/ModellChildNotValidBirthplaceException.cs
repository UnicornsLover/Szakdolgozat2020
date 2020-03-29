using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    internal class ModellChildNotValidBirthplaceException : Exception
    {
        public ModellChildNotValidBirthplaceException()
        {
        }

        public ModellChildNotValidBirthplaceException(string message) : base(message)
        {
        }

        public ModellChildNotValidBirthplaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildNotValidBirthplaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}