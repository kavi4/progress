using System;
using BaseException = System.Exception;

namespace Progress.Shared.Exception
{
    public class ApplicationException : BaseException
    {
        protected string code = "ApplicationException";

        public string GetCode()
        {
            return this.code;
        }

        public ApplicationException()
        {

        }

        public ApplicationException(string message) : base(message)
        {

        }

        public ApplicationException(string message, string code) : base(message)
        {
            this.code = code;
        }

        public ApplicationException(string message, string code, ApplicationException inner) : base(message, inner)
        {
            this.code = code;
        }
    }
}

