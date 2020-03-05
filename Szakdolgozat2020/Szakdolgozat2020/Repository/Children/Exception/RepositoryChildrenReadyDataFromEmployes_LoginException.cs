using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Children
{
    [Serializable]
    internal class RepositoryChildrenReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryChildrenReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryChildrenReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryChildrenReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}