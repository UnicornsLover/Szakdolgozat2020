using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Parents
{
    [Serializable]
    internal class RepositoryParentException : Exception
    {
        public RepositoryParentException()
        {
        }

        public RepositoryParentException(string message) : base(message)
        {
        }

        public RepositoryParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}