using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Souls
{
    [Serializable]
    internal class RepositorySoulsReadyDataFromEmployes_LoginException : Exception
    {
        public RepositorySoulsReadyDataFromEmployes_LoginException()
        {
        }

        public RepositorySoulsReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositorySoulsReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulsReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}