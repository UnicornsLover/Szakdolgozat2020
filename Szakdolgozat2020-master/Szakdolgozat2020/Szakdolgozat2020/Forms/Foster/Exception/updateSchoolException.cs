using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class updateSchoolException : Exception
    {
        public updateSchoolException()
        {
        }

        public updateSchoolException(string message) : base(message)
        {
        }

        public updateSchoolException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateSchoolException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}