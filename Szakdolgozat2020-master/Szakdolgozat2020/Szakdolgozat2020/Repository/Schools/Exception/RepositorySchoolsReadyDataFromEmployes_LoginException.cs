using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Schools
{
    [Serializable]
    internal class RepositorySchoolsReadyDataFromEmployes_LoginException : Exception
    {
        public RepositorySchoolsReadyDataFromEmployes_LoginException()
        {
        }

        public RepositorySchoolsReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositorySchoolsReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySchoolsReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}