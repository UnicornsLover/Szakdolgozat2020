using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020
{
    [Serializable]
    internal class RepositorySoulsExceptionCantDelete : Exception
    {
        public RepositorySoulsExceptionCantDelete()
        {
        }

        public RepositorySoulsExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositorySoulsExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulsExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}