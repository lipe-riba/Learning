using System;
using System.Data.Entity;
using System.Linq;
using EntityFrameworkBase.Data.Entities;
using EntityFrameworkBase.Data.Contexts.Configurations;

namespace EntityFrameworkBase.Data.Contexts
{
    [DbConfigurationType(typeof(BaseConfiguration))]
	public abstract class BaseContext : DbContext
	{
		public BaseContext(string connectionString, params Type[] typesOfBaseConfiguration) : base(connectionString) 
		{
            _typesOfBaseConfiguration = typesOfBaseConfiguration;
		}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (Type type in _typesOfBaseConfiguration)
            {
                Activator.CreateInstance(type, modelBuilder);
            }
        }

        private Type[] _typesOfBaseConfiguration;
	}
}
