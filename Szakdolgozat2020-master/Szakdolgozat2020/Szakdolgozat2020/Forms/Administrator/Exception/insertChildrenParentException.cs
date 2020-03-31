using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class insertChildrenParentException : Exception
    {
        public insertChildrenParentException()
        {
        }

        public insertChildrenParentException(string message) : base(message)
        {
        }

        public insertChildrenParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertChildrenParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}