using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public interface IProcess
    {
        public string GetId();

        public string GetName();

        public string GetProcessType();

        public float GetProgress();

        public float GetMaxProgress();

        public string GetStatus();
    }
}

