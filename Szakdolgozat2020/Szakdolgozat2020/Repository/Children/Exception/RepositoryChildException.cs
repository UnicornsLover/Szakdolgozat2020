using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Children
{
    [Serializable]
    internal class RepositoryChildException : Exception
    {
        public RepositoryChildException()
        {
        }

        public RepositoryChildException(string message) : base(message)
        {
        }

        public RepositoryChildException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}