using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public abstract class IndependentProcess : Process, IIndependentProcess
    {
        protected float progress;
        protected float maxProgress;

        protected List<IResultMessage> results;

        public IndependentProcess(string id, string message = "", string name = "", float maxProgress = 100) : base(id, message, name)
        {
            this.progress = 0;
            this.maxProgress = maxProgress;
            this.results = new List<IResultMessage>();
            this.maxProgress = maxProgress;
        }

        public override float GetMaxProgress()
        {
            return this.maxProgress;
        }

        public void IncrementProgress(float increment)
        {
            float result = this.progress += increment;

            if (result > this.maxProgress)
            {
                this.progress = this.maxProgress;
                return;
            }

            this.progress += increment;
        }

        public void AddResultMessage(IResultMessage resultMessage)
        {
            this.results.Add(resultMessage);
        }

        public List<IResultMessage> GetResultMessages()
        {
            throw new NotImplementedException();
        }

        public override float GetProgress()
        {
            return this.progress;
        }

        public override string GetProcessType()
        {
            return ProcessTypeDictionary.SINGLE;
        }
    }
}

