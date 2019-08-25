using System;

namespace WebShop.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DataModified { set; get; }
    }
}