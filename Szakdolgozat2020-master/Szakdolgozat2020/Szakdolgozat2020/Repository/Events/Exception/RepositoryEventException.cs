using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Events
{
    [Serializable]
    internal class RepositoryEventException : Exception
    {
        public RepositoryEventException()
        {
        }

        public RepositoryEventException(string message) : base(message)
        {
        }

        public RepositoryEventException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}