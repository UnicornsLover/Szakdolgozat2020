using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class ModellParentNotValidNameException : Exception
    {
        public ModellParentNotValidNameException()
        {
        }

        public ModellParentNotValidNameException(string message) : base(message)
        {
        }

        public ModellParentNotValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellParentNotValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}