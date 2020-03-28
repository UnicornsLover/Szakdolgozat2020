using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class updateParentException : Exception
    {
        public updateParentException()
        {
        }

        public updateParentException(string message) : base(message)
        {
        }

        public updateParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}