using System;
using EntityFrameworkBase.Data.Contexts;

namespace Tests
{
    public class InventoryContext: BaseContext
    {
        public InventoryContext()
            : base("<SQL CONNECTION>", new Type[] { 
                typeof(ProductConfiguration)
            })
        {
        }
    }
}
