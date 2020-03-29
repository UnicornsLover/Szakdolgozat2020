using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Events
{
    [Serializable]
    internal class RepositoryEventExceptionCantMoodify : Exception
    {
        public RepositoryEventExceptionCantMoodify()
        {
        }

        public RepositoryEventExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryEventExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}