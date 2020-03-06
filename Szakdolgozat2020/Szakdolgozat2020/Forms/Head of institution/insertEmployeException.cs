using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Head_of_institution
{
    [Serializable]
    internal class insertEmployeException : Exception
    {
        public insertEmployeException()
        {
        }

        public insertEmployeException(string message) : base(message)
        {
        }

        public insertEmployeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected insertEmployeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}