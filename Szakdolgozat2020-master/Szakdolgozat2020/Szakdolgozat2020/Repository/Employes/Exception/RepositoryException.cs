using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmployeException : Exception
    {
        public RepositoryEmployeException()
        {
        }

        public RepositoryEmployeException(string message) : base(message)
        {
        }

        public RepositoryEmployeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmployeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}