using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface IResultMessage
    {
        public string GetMessageType();

        public string GetMessage();
    }
}

