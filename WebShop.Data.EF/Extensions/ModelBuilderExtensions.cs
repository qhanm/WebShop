using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShop.Data.EF.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, DbEntityConfiguration<TEntity> entityConfiguration)
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configuration);
        }
    }

    public abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configuration(EntityTypeBuilder<TEntity> entity);
    }
}