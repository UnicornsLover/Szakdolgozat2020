using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms
{
    [Serializable]
    internal class newPasswordException : Exception
    {
        public newPasswordException()
        {
        }

        public newPasswordException(string message) : base(message)
        {
        }

        public newPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected newPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}