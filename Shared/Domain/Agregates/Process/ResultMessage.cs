using System;

namespace Progress.Shared.Domain.Agregates.Process
{
    public class ResultMessage : ValueObject, IResultMessage
    {
        protected string messageType;
        protected string message;

        public ResultMessage(string type, string message)
        {
            this.messageType = type;
            this.message = message;
        }

        public string GetMessageType()
        {
            return this.messageType;
        }

        public string GetMessage()
        {
            return this.message;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return messageType;
            yield return message;
        }
    }
}

