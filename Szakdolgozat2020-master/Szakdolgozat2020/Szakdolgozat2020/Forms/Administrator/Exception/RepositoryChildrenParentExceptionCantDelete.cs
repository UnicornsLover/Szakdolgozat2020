using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Administrator
{
    [Serializable]
    internal class RepositoryChildrenParentExceptionCantDelete : Exception
    {
        public RepositoryChildrenParentExceptionCantDelete()
        {
        }

        public RepositoryChildrenParentExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChildrenParentExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenParentExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}