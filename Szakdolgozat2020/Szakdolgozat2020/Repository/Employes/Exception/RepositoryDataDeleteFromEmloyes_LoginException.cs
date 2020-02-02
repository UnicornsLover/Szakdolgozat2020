using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryDataDeleteFromEmloyes_LoginException : Exception
    {
        public RepositoryDataDeleteFromEmloyes_LoginException()
        {
        }

        public RepositoryDataDeleteFromEmloyes_LoginException(string message) : base(message)
        {
        }

        public RepositoryDataDeleteFromEmloyes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryDataDeleteFromEmloyes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}