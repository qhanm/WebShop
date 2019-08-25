using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data.Enums;
using WebShop.Data.Interfaces;
using WebShop.Infrastructure.SharedKernel;

namespace WebShop.Data.Entities
{
    class Footer : DomainEntity<int>, ISwichable
    {
        public string Content { set; get; }

        public Status Status { set; get; }
    }
}
