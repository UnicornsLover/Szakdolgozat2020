using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmployeExceptionCantAdd : Exception
    {
        public RepositoryEmployeExceptionCantAdd()
        {
        }

        public RepositoryEmployeExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryEmployeExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmployeExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}