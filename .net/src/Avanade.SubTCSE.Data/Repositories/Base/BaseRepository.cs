using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, Tid>
        : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>

    {
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual async Task<TEntity> FindById(Tid Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
