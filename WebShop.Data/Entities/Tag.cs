﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebShop.Infrastructure.SharedKernel;

namespace WebShop.Data.Entities
{
    [Table("Tag")]
    public class Tag : DomainEntity<string> 
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Type { get; set; }

    }
}
