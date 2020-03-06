using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Parents
{
    [Serializable]
    internal class RepositoryParentsReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryParentsReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryParentsReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryParentsReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryParentsReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}