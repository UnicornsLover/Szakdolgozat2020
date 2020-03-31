using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenParents
{
    [Serializable]
    internal class RepositoryChildrenParentReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryChildrenParentReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryChildrenParentReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryChildrenParentReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenParentReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}