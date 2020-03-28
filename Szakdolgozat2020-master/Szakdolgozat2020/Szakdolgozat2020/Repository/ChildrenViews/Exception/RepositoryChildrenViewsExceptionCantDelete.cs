using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChildrenViewsExceptionCantDelete : Exception
    {
        public RepositoryChildrenViewsExceptionCantDelete()
        {
        }

        public RepositoryChildrenViewsExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryChildrenViewsExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewsExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}