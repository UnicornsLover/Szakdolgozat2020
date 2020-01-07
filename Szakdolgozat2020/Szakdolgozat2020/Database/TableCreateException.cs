using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Database
{
    [Serializable]
    internal class TableCreateException : Exception
    {
        public TableCreateException()
        {
        }

        public TableCreateException(string message) : base(message)
        {
        }

        public TableCreateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TableCreateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}