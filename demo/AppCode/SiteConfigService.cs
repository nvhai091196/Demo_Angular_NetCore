

using System.Linq;
using demo.domain.Services.Administration;
using demo.Models;

namespace AppCode
{
    public interface ISiteConfigService
    {
        //SiteConfig GetSiteConfig();
    }

    //public class SiteConfigService : ISiteConfigService
    //{
        // private readonly ICategoryService categoryService;
        // public SiteConfig siteConfig {get;set;}
        // public SiteConfigService(ICategoryService _categoryService){
        //     this.categoryService = _categoryService;
        //     var items = categoryService.GetCategoryItems("SYSTEM_SETTING");
        //     string currentLanguage = System.Threading.Thread.CurrentThread.CurrentCulture.EnglishName;
        //     var isVI = string.Equals(currentLanguage, new System.Globalization.CultureInfo("VI").EnglishName);
        //     var isEN = string.Equals(currentLanguage, new System.Globalization.CultureInfo("EN").EnglishName);
        //     if (items.Count() > 0)
        //     {
        //         siteConfig = new SiteConfig()
        //         {
        //             SiteName = items.Where(m => m.Code == nameof(siteConfig.SiteName)).FirstOrDefault()?.Value ?? "",
        //             Address = items.Where(m => m.Code == nameof(siteConfig.Address)).FirstOrDefault()?.Value ?? "",
        //             Email = items.Where(m => m.Code == nameof(siteConfig.Email)).FirstOrDefault()?.Value ?? "",
        //             FacebookUrl = items.Where(m => m.Code == nameof(siteConfig.FacebookUrl)).FirstOrDefault()?.Value ?? "",
        //             TwitterUrl = items.Where(m => m.Code == nameof(siteConfig.TwitterUrl)).FirstOrDefault()?.Value ?? "",
        //             InstagramUrl = items.Where(m => m.Code == nameof(siteConfig.InstagramUrl)).FirstOrDefault()?.Value ?? "",
        //             YoutubeUrl = items.Where(m => m.Code == nameof(siteConfig.YoutubeUrl)).FirstOrDefault()?.Value ?? "",
        //             Phone = items.Where(m => m.Code == nameof(siteConfig.Phone)).FirstOrDefault()?.Value ?? "",
        //             Hotline =  items.Where(m => m.Code == nameof(siteConfig.Hotline)).FirstOrDefault()?.Value ?? "",
        //             SiteDescription = items.Where(m => m.Code == nameof(siteConfig.SiteDescription)).FirstOrDefault()?.Value ?? "",
        //             PowerBy = items.Where(m => m.Code == nameof(siteConfig.PowerBy)).FirstOrDefault()?.Value ?? "",
        //             PowerByUrl1 = items.Where(m => m.Code == nameof(siteConfig.PowerByUrl1)).FirstOrDefault()?.Value ?? "",
        //             PowerByUrl2 = items.Where(m => m.Code == nameof(siteConfig.PowerByUrl2)).FirstOrDefault()?.Value ?? "",
        //             PowerByUrl3 = items.Where(m => m.Code == nameof(siteConfig.PowerByUrl3)).FirstOrDefault()?.Value ?? "",
        //             PowerByWebsiteUrl = items.Where(m => m.Code == nameof(siteConfig.PowerByWebsiteUrl)).FirstOrDefault()?.Value ?? "",
        //         };
        //     }
        // }
        // public SiteConfig GetSiteConfig()
        // {
        //     return (siteConfig ?? new SiteConfig());
        // }
    //}
}