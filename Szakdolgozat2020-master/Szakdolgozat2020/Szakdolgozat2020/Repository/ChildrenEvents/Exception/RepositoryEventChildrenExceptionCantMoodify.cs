using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    [Serializable]
    internal class RepositoryEventChildrenExceptionCantMoodify : Exception
    {
        public RepositoryEventChildrenExceptionCantMoodify()
        {
        }

        public RepositoryEventChildrenExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryEventChildrenExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventChildrenExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}