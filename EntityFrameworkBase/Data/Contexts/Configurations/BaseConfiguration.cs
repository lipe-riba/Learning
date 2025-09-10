using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace EntityFrameworkBase.Data.Contexts.Configurations
{
    public sealed class BaseConfiguration : DbConfiguration
    {
        public BaseConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}
