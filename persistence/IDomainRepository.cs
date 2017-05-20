using GFramework.core.domainEntities;

namespace GFramework.core.persistence
{
    public interface IDomainRepository<T> where T: IValidateableEntity
    {
    }
}
