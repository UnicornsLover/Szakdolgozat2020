using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class updateEventException : Exception
    {
        public updateEventException()
        {
        }

        public updateEventException(string message) : base(message)
        {
        }

        public updateEventException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateEventException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}