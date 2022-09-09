using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface ISingleProcess
    {
        public void IncrementProgress(float increment);

        public void AddResultMessage(ResultMessage resultMessage);
    }
}

