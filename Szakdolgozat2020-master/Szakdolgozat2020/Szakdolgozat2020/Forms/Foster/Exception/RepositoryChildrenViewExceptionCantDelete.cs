using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Foster
{
    [Serializable]
    internal class RepositoryChildrenViewExceptionCantDelete : Exception
    {
        public RepositoryChildrenViewExceptionCantDelete()
        {
        }

        public RepositoryChildrenViewExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChildrenViewExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}