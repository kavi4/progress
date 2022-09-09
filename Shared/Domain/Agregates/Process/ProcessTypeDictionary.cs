using System;
namespace Progress.Shared.Domain.Agregates.Process
{
    public class ProcessTypeDictionary : IDictionary
    {
        public const string SINGLE = "single";
        public const string MULTIPLE = "multiple";
        public const string DISTRIBUTED = "distributed";

        public ProcessTypeDictionary()
        {
        }

        public string[] GetCodes()
        {
            return new string[] {
                ProcessTypeDictionary.SINGLE,
                ProcessTypeDictionary.MULTIPLE,
                ProcessTypeDictionary.DISTRIBUTED,
            };
        }
    }
}

