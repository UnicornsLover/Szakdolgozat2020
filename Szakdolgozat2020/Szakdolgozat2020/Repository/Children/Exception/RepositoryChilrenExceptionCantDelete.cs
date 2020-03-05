using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Children
{
    [Serializable]
    internal class RepositoryChilrenExceptionCantDelete : Exception
    {
        public RepositoryChilrenExceptionCantDelete()
        {
        }

        public RepositoryChilrenExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChilrenExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChilrenExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}