using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Parents
{
    [Serializable]
    internal class RepositoryParentsExceptionCantDelete : Exception
    {
        public RepositoryParentsExceptionCantDelete()
        {
        }

        public RepositoryParentsExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryParentsExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentsExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}