using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Schools
{
    [Serializable]
    internal class RepositorySchoolExceptionCantDelete : Exception
    {
        public RepositorySchoolExceptionCantDelete()
        {
        }

        public RepositorySchoolExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositorySchoolExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySchoolExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}