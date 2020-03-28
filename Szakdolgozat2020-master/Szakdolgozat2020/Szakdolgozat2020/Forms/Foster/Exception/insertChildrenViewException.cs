using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class insertChildrenViewException : Exception
    {
        public insertChildrenViewException()
        {
        }

        public insertChildrenViewException(string message) : base(message)
        {
        }

        public insertChildrenViewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertChildrenViewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}