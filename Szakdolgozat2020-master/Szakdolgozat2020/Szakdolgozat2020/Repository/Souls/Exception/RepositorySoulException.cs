using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Souls
{
    [Serializable]
    internal class RepositorySoulException : Exception
    {
        public RepositorySoulException()
        {
        }

        public RepositorySoulException(string message) : base(message)
        {
        }

        public RepositorySoulException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}