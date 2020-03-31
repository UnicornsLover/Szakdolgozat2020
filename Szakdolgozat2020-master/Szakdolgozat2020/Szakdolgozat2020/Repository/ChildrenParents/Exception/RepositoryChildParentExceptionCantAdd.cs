using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    [Serializable]
    internal class RepositoryChildParentExceptionCantAdd : Exception
    {
        public RepositoryChildParentExceptionCantAdd()
        {
        }

        public RepositoryChildParentExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryChildParentExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildParentExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}