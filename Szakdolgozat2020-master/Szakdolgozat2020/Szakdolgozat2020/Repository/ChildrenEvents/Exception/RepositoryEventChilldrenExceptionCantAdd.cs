using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    [Serializable]
    internal class RepositoryEventChilldrenExceptionCantAdd : Exception
    {
        public RepositoryEventChilldrenExceptionCantAdd()
        {
        }

        public RepositoryEventChilldrenExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryEventChilldrenExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventChilldrenExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}