using GFramework.core.domainEntities;

namespace GFramework.core.converters
{
    public interface IDTOConverter<T> where T: IEntity
    {

        IDomainEntity Convert(T DTO);

    }
}
