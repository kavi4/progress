using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public class DistributedProcess : Process, IDistributedProcess
    {
        protected int initTime;
        protected List<IProcess> processes;

        public DistributedProcess(string id, string message = "", string name = "", int initTime = 60) : base(id, message, name)
        {
            this.processes = new List<IProcess>();
            this.initTime = initTime;
        }

        public void AddSubProcess(IProcess process)
        {
            this.processes.Add(process);
        }

        public int GetInitTime()
        {
            return this.initTime;
        }

        public override float GetProgress()
        {
            return this.processes.Sum(p => p.GetProgress());
        }

        public override float GetMaxProgress()
        {
            return this.processes.Sum(p => p.GetMaxProgress());
        }

        public override string GetProcessType()
        {
            return ProcessTypeDictionary.DISTRIBUTED;
        }

        public override string GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}

