using System;
using System.Text;
using System.Text.RegularExpressions;

namespace demo.utilities
{
    public class TextHelper
    {
        public static string RewriteProductDetailUrl(string text, int? id){
            return $"{Statics.DOMAIN}/san-pham/{TextHelper.GetUrlText(text)}-{id}.html";
        }
        public static string RewriteBlogUrl(string text, int? id){
            return $"{Statics.DOMAIN}/blog/{TextHelper.GetUrlText(text)}-{id}.html";
        }
        public static string RewriteBlogDetailUrl(string text, int? id){
            return $"{Statics.DOMAIN}/{TextHelper.GetUrlText(text)}-{id}.html";
        }
         public static string GetUrlText(string text)
        {
            return GetText(text).Replace(" ", "-")
                                .Replace("/", "-")
                                .Replace("--", "-")
                                .Replace("?","-")
                                .Replace("%","-");
        }
        public static string GetText(string text)
        {
            if (string.IsNullOrEmpty(text))
                text = " ";
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = text.Normalize(NormalizationForm.FormD);
            string unsignText = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower();
            return unsignText;
        }
    }
}