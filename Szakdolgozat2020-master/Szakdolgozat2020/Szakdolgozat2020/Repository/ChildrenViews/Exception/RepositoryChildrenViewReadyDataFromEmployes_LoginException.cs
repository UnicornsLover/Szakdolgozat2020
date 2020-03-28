using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenViews
{
    [Serializable]
    internal class RepositoryChildrenViewReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryChildrenViewReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryChildrenViewReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryChildrenViewReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildrenViewReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}