using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    abstract public class Process : Aggregate, IProcess
    {
        protected string name;
        protected string message;

        public Process(string id, string message = "", string name = "") : base(id)
        {
            this.id = id;
            this.message = message;
            this.name = name;
        }

        public abstract string GetProcessType();

        public abstract float GetProgress();

        public abstract float GetMaxProgress();

        public string GetMessage()
        {
            return this.message;
        }

        public string GetName()
        {
            return this.name;
        }

        abstract public string GetStatus();
    }
}

