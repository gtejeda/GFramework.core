using GFramework.core.domainEntities;

namespace GFramework.core.persistence
{
    /// <summary>
    /// This interface gives you the default Created, Update and Delete Items used for every application.
    /// </summary>
    public interface IDefaultDomainRepository: IDomainRepository<IDomainEntity>
    {
        void Create(IDomainEntity DomainEntity);

        void Update(IDomainEntity DomainEntity);

        void Delete(IDomainEntity DomainEntity);

    }
}
