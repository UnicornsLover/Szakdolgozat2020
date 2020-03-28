using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChildrenViewExceptionCantMoodify : Exception
    {
        public RepositoryChildrenViewExceptionCantMoodify()
        {
        }

        public RepositoryChildrenViewExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryChildrenViewExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}