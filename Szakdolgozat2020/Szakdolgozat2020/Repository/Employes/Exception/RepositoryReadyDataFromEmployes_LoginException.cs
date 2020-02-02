using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}