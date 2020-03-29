using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class insertEventChildrenException : Exception
    {
        public insertEventChildrenException()
        {
        }

        public insertEventChildrenException(string message) : base(message)
        {
        }

        public insertEventChildrenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertEventChildrenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}