namespace WebShop.Data.Interfaces
{
    public interface IHasSeoMetadata
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeyWords { set; get; }
        string SeoDescription { set; get; }
    }
}