using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmloyes_LoginDropException : Exception
    {
        public RepositoryEmloyes_LoginDropException()
        {
        }

        public RepositoryEmloyes_LoginDropException(string message) : base(message)
        {
        }

        public RepositoryEmloyes_LoginDropException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmloyes_LoginDropException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}