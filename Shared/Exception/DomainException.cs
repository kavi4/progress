using System;
namespace Progress.Shared.Exception
{
    public class DomainException : ApplicationException
    {
        protected new string code = "DomainException";

        public DomainException()
        {

        }

        public DomainException(string message) : base(message)
        {

        }

        public DomainException(string message, string code) : base(message, code)
        {

        }

        public DomainException(string message, string code, ApplicationException inner) : base(message, code, inner)
        {

        }
    }
}

