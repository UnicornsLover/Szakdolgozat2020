using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    [Serializable]
    internal class RepositoryEventChildrenExceptionCantDelete : Exception
    {
        public RepositoryEventChildrenExceptionCantDelete()
        {
        }

        public RepositoryEventChildrenExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryEventChildrenExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventChildrenExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}