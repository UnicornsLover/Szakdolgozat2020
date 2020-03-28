using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class updateChildrenViewException : Exception
    {
        public updateChildrenViewException()
        {
        }

        public updateChildrenViewException(string message) : base(message)
        {
        }

        public updateChildrenViewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateChildrenViewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}