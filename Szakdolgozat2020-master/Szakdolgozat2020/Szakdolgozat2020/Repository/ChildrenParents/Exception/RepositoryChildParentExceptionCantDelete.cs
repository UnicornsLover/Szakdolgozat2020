using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    [Serializable]
    internal class RepositoryChildParentExceptionCantDelete : Exception
    {
        public RepositoryChildParentExceptionCantDelete()
        {
        }

        public RepositoryChildParentExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChildParentExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildParentExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}