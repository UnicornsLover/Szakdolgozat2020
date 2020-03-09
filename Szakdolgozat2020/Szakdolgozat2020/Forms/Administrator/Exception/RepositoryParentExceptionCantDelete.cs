using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class RepositoryParentExceptionCantDelete : Exception
    {
        public RepositoryParentExceptionCantDelete()
        {
        }

        public RepositoryParentExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryParentExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}