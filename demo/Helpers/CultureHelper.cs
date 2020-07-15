

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace demo.Helpers{

    public class CultureHelper{
        public static string VI = "vi-VN";

        public static string EN = "en-US";

        public static bool IsVN (HttpContext context){
            var requestCulture = context.Features.Get<IRequestCultureFeature>();
            return requestCulture.RequestCulture.UICulture.Name == VI;
        }
    }
}