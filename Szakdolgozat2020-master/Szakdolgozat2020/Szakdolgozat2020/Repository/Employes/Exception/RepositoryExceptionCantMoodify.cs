using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Employes
{
    [Serializable]
    internal class RepositoryEmployeExceptionCantMoodify : Exception
    {
        public RepositoryEmployeExceptionCantMoodify()
        {
        }

        public RepositoryEmployeExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositoryEmployeExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryEmployeExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}