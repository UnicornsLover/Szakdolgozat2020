using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    [Serializable]
    internal class RepositoryChildParentException : Exception
    {
        public RepositoryChildParentException()
        {
        }

        public RepositoryChildParentException(string message) : base(message)
        {
        }

        public RepositoryChildParentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildParentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}