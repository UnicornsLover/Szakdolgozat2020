using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Parents
{
    [Serializable]
    internal class RepositoryParentExceptionCantMoodify : Exception
    {
        public RepositoryParentExceptionCantMoodify()
        {
        }

        public RepositoryParentExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryParentExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}