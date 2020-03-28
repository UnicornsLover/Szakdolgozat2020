using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmployeesReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryEmployeesReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryEmployeesReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryEmployeesReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmployeesReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}