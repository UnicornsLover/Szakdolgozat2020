using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryExceptionCantMoodify : Exception
    {
        public RepositoryExceptionCantMoodify()
        {
        }

        public RepositoryExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}