using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface IIndependentProcess : IProcess
    {
        public void IncrementProgress(float increment);

        public List<IResultMessage> GetResultMessages();

        public void AddResultMessage(IResultMessage resultMessage);
    }
}

