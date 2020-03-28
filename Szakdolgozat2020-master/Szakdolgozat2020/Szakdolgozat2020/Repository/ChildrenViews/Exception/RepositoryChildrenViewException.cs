using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChildrenViewException : Exception
    {
        public RepositoryChildrenViewException()
        {
        }

        public RepositoryChildrenViewException(string message) : base(message)
        {
        }

        public RepositoryChildrenViewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}