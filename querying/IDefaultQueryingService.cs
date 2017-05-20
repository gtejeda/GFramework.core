using System.Collections.Generic;
using GFramework.core.domainEntities;

namespace GFramework.core.querying
{
    public interface IDefaultQueryingService<T> : IQueryingService<T> where T : IEntity
    {
        IList<T> GetAll();

        T GetSingle(object Id);

    }
}
