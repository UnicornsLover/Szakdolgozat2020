using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class ModellParentNotValidSexException : Exception
    {
        public ModellParentNotValidSexException()
        {
        }

        public ModellParentNotValidSexException(string message) : base(message)
        {
        }

        public ModellParentNotValidSexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellParentNotValidSexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}