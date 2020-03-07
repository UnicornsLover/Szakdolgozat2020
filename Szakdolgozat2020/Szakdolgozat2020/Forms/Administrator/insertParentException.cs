using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class insertParentException : Exception
    {
        public insertParentException()
        {
        }

        public insertParentException(string message) : base(message)
        {
        }

        public insertParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}