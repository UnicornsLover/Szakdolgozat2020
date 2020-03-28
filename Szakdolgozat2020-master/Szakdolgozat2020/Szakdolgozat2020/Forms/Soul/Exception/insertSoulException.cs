using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Soul
{
    [Serializable]
    internal class insertSoulException : Exception
    {
        public insertSoulException()
        {
        }

        public insertSoulException(string message) : base(message)
        {
        }

        public insertSoulException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertSoulException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}