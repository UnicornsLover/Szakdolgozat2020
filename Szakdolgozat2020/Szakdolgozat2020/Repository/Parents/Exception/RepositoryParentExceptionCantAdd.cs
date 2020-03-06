using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Parents
{
    [Serializable]
    internal class RepositoryParentExceptionCantAdd : Exception
    {
        public RepositoryParentExceptionCantAdd()
        {
        }

        public RepositoryParentExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryParentExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}