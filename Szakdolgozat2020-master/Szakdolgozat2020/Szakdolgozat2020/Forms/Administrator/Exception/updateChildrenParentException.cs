using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class updateChildrenParentException : Exception
    {
        public updateChildrenParentException()
        {
        }

        public updateChildrenParentException(string message) : base(message)
        {
        }

        public updateChildrenParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateChildrenParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}