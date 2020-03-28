using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Database
{
    [Serializable]
    internal class InsertUsersException : Exception
    {
        public InsertUsersException()
        {
        }

        public InsertUsersException(string message) : base(message)
        {
        }

        public InsertUsersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsertUsersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}