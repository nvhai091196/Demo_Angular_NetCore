using Microsoft.Extensions.Localization;
using System.Reflection;
 
namespace Localization
{
    public class CommonLocalizationService
    {
        private readonly IStringLocalizer localizer;
        public CommonLocalizationService(IStringLocalizerFactory factory)
        {
            var assemblyName = new AssemblyName(typeof(Wording).GetTypeInfo().Assembly.FullName);
            localizer = factory.Create(nameof(Wording), assemblyName.Name);
        }
 
        public string Get(string key)
        {
            return localizer[key];
        }
    }
}