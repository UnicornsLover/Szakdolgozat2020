using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.ChildrenEvents
{
    [Serializable]
    internal class RepositoryEventChildrenReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryEventChildrenReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryEventChildrenReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryEventChildrenReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventChildrenReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}