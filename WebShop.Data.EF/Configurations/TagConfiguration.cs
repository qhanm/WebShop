using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebShop.Data.EF.Extensions;
namespace WebShop.Data.EF.Configurations
{
    internal class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            throw new NotImplementedException();
        }

    }
}