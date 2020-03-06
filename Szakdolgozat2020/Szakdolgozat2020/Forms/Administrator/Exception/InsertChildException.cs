using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Nevelo
{
    [Serializable]
    internal class insertChildException : Exception
    {
        public insertChildException()
        {
        }

        public insertChildException(string message) : base(message)
        {
        }

        public insertChildException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertChildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}