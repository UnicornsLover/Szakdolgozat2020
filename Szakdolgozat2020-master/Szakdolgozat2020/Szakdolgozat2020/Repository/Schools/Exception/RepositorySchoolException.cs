using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Schools
{
    [Serializable]
    internal class RepositorySchoolException : Exception
    {
        public RepositorySchoolException()
        {
        }

        public RepositorySchoolException(string message) : base(message)
        {
        }

        public RepositorySchoolException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySchoolException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}