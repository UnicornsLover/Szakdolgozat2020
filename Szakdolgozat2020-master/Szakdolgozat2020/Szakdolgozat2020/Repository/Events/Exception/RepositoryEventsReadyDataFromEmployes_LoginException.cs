using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Events
{
    [Serializable]
    internal class RepositoryEventsReadyDataFromEmployes_LoginException : Exception
    {
        public RepositoryEventsReadyDataFromEmployes_LoginException()
        {
        }

        public RepositoryEventsReadyDataFromEmployes_LoginException(string message) : base(message)
        {
        }

        public RepositoryEventsReadyDataFromEmployes_LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEventsReadyDataFromEmployes_LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}