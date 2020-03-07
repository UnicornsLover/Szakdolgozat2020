using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Nevelo
{
    [Serializable]
    internal class updateChildException : Exception
    {
        public updateChildException()
        {
        }

        public updateChildException(string message) : base(message)
        {
        }

        public updateChildException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateChildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}