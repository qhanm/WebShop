using WebShop.Data.Enums;

namespace WebShop.Data.Interfaces
{
    public interface ISwichable
    {
        Status Status { get; set; }
    }
}