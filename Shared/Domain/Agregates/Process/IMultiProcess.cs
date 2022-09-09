using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface IMultiProcess : IProcess
    {
        public void AddSubProcess(IProcess process);
    }
}

