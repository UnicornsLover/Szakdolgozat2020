using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Nevelo
{
    [Serializable]
    internal class RepositoryChildExceptionCantDelete : Exception
    {
        public RepositoryChildExceptionCantDelete()
        {
        }

        public RepositoryChildExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChildExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}