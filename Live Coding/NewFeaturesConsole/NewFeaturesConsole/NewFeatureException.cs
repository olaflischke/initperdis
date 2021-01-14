using System;
using System.Runtime.Serialization;

namespace NewFeaturesConsole
{
    [Serializable]
    internal class NewFeatureException : Exception
    {
        public NewFeatureException()
        {
        }

        public NewFeatureException(string message) : base(message)
        {
        }

        public NewFeatureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NewFeatureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}