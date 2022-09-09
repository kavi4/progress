using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface IDistributedProcess : IProcess
    {
        public int GetInitTime();

        public void AddSubProcess(IProcess process);
    }
}