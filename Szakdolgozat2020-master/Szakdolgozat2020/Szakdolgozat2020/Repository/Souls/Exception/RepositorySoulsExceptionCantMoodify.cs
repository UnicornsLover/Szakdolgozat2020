using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020
{
    [Serializable]
    internal class RepositorySoulsExceptionCantMoodify : Exception
    {
        public RepositorySoulsExceptionCantMoodify()
        {
        }

        public RepositorySoulsExceptionCantMoodify(string message) : base(message)
        {
        }

        public RepositorySoulsExceptionCantMoodify(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulsExceptionCantMoodify(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}