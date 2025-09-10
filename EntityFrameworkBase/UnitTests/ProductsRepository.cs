using EntityFrameworkBase.Data.Contexts;
using EntityFrameworkBase.Data.Repositories;

namespace Tests
{
    public class ProductsRepository : BaseRepository
    {
        public ProductsRepository(BaseContext context)
            : base(context)
        {
        }
    }
}
