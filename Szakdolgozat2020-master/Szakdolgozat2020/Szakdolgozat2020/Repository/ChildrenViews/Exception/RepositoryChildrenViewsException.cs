using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChildrenViewsException : Exception
    {
        public RepositoryChildrenViewsException()
        {
        }

        public RepositoryChildrenViewsException(string message) : base(message)
        {
        }

        public RepositoryChildrenViewsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}