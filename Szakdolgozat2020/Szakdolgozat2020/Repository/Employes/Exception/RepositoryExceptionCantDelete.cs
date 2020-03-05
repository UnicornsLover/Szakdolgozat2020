using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmployeExceptionCantDelete : Exception
    {
        public RepositoryEmployeExceptionCantDelete()
        {
        }

        public RepositoryEmployeExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositoryEmployeExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmployeExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}