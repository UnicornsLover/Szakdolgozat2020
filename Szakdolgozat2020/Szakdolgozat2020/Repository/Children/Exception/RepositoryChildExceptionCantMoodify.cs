using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Children
{
    [Serializable]
    internal class RepositoryChildExceptionCantMoodify : Exception
    {
        public RepositoryChildExceptionCantMoodify()
        {
        }

        public RepositoryChildExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryChildExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}