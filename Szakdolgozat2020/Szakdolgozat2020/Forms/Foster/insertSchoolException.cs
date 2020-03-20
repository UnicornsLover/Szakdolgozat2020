using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class insertSchoolException : Exception
    {
        public insertSchoolException()
        {
        }

        public insertSchoolException(string message) : base(message)
        {
        }

        public insertSchoolException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertSchoolException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}