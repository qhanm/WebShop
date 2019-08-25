using System;
using System.Collections.Generic;
using WebShop.Data.Enums;
using WebShop.Data.Interfaces;
using WebShop.Infrastructure.SharedKernel;

namespace WebShop.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetadata, ISwichable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public string Name { set; get; }

        public string Description { set; get; }

        public int? ParentId { set; get; }

        public int? HomeOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyWords { set; get; }
        public string SeoDescription { set; get; }
        public Status Status { set; get; }
        public int SortOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DataModified { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}