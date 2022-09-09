using System;
using System.Linq;

namespace Progress.Shared.Domain.Agregates.Process
{
    public class MultiProcess : Process, IMultiProcess
    {
        protected List<IProcess> processes;

        public MultiProcess(string id, string message = "", string name = "") : base(id, message, name)
        {
            this.processes = new List<IProcess>();
        }

        public void AddSubProcess(IProcess process)
        {
            this.processes.Add(process);
        }

        public override string GetProcessType()
        {
            return ProcessTypeDictionary.MULTIPLE;
        }

        public override float GetProgress()
        {
            return this.processes.Sum(p => p.GetProgress());
        }

        public override float GetMaxProgress()
        {
            return this.processes.Sum(p => p.GetMaxProgress());
        }

        public override string GetStatus()
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}

