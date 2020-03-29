using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    [Serializable]
    internal class RepositoryEventChildException : Exception
    {
        public RepositoryEventChildException()
        {
        }

        public RepositoryEventChildException(string message) : base(message)
        {
        }

        public RepositoryEventChildException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventChildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}