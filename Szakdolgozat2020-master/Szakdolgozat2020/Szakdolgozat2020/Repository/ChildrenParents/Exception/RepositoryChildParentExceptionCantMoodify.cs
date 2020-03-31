using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    [Serializable]
    internal class RepositoryChildParentExceptionCantMoodify : Exception
    {
        public RepositoryChildParentExceptionCantMoodify()
        {
        }

        public RepositoryChildParentExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryChildParentExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildParentExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}