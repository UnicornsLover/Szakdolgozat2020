using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Events
{
    [Serializable]
    internal class RepositoryEventExceptionCantAdd : Exception
    {
        public RepositoryEventExceptionCantAdd()
        {
        }

        public RepositoryEventExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryEventExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}