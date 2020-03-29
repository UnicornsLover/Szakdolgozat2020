using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class insertEventException : Exception
    {
        public insertEventException()
        {
        }

        public insertEventException(string message) : base(message)
        {
        }

        public insertEventException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertEventException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}