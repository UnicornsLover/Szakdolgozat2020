using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Head_of_institution
{
    [Serializable]
    internal class updateEmployeException : Exception
    {
        public updateEmployeException()
        {
        }

        public updateEmployeException(string message) : base(message)
        {
        }

        public updateEmployeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected updateEmployeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}