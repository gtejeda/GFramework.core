namespace GFramework.core.exceptions
{
    public class EntityIsInvalidException : FrameworkException
    {
        public EntityIsInvalidException() : base("The change cannot be applied as it contradicts currently enforced business rules")
        {
        }
        public EntityIsInvalidException(string ExceptionMessage) : base(ExceptionMessage)
        {
        }
    }
}
