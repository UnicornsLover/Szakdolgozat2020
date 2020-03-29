using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class updateEventChildrenException : Exception
    {
        public updateEventChildrenException()
        {
        }

        public updateEventChildrenException(string message) : base(message)
        {
        }

        public updateEventChildrenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateEventChildrenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}