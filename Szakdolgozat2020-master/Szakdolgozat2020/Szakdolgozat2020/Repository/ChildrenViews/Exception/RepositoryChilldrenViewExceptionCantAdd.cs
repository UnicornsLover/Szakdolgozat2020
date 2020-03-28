using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChilldrenViewExceptionCantAdd : Exception
    {
        public RepositoryChilldrenViewExceptionCantAdd()
        {
        }

        public RepositoryChilldrenViewExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryChilldrenViewExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChilldrenViewExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}