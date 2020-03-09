using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Schools
{
    [Serializable]
    internal class RepositorySchoolExceptionCantMoodify : Exception
    {
        public RepositorySchoolExceptionCantMoodify()
        {
        }

        public RepositorySchoolExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositorySchoolExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySchoolExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}