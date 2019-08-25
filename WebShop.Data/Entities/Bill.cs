using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data.Enums;
using WebShop.Data.Interfaces;
using WebShop.Infrastructure.SharedKernel;

namespace WebShop.Data.Entities
{
    internal class Bill : DomainEntity<int>, ISwichable, IDateTracking
    {



        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DataModified { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyWords { set; get; }
        public string SeoDescription { set; get; }
    }
}
