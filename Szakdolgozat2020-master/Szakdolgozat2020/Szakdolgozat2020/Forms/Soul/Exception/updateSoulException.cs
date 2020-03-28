using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Soul
{
    [Serializable]
    internal class updateSoulException : Exception
    {
        public updateSoulException()
        {
        }

        public updateSoulException(string message) : base(message)
        {
        }

        public updateSoulException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateSoulException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}