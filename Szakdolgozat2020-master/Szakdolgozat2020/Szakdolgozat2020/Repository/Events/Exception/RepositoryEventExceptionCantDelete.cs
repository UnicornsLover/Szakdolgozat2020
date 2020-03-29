using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Events
{
    [Serializable]
    internal class RepositoryEventExceptionCantDelete : Exception
    {
        public RepositoryEventExceptionCantDelete()
        {
        }

        public RepositoryEventExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryEventExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}