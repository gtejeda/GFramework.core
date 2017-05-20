namespace GFramework.core.exceptions
{
    public class DomainRepositoryOperationFailedException : FrameworkException
    {
        public DomainRepositoryOperationFailedException(string OutErrorNumber) : base("The Domain Repository Operation failed " + OutErrorNumber)
        {
        }
    }
}
