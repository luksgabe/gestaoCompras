using SafeWeb.Data.Data;
using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;

namespace SafeWeb.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(SafeWebContext context) : base(context)
        {

        }

    }
}
