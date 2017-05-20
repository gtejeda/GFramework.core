using System;

namespace GFramework.core.exceptions
{
    public class FrameworkException: ApplicationException
    {

        public FrameworkException()
        {
        }

        public FrameworkException(string OverrideDefaultMessage) : base(OverrideDefaultMessage)
        {

        }

    }
}
