using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public class ProcessStatusDictionary : IDictionary
    {
        public const string NEW = "new";
        public const string INIT = "init";
        public const string PROCESSING = "processing";
        public const string COMPLETE = "complete";
        public const string FAIL = "fail";

        public ProcessStatusDictionary()
        {

        }

        string[] IDictionary.GetCodes()
        {
            return new string[]{
                ProcessStatusDictionary.NEW,
                ProcessStatusDictionary.INIT,
                ProcessStatusDictionary.PROCESSING,
                ProcessStatusDictionary.COMPLETE,
                ProcessStatusDictionary.FAIL,
            };
        }
    }
}

