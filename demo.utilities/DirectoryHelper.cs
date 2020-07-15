using System.IO;

namespace demo.utilities
{
      public class DirectoryHelper
    {
        public static DirectoryInfo GetFileUploadFolder(string rootAppDir, string folder)
        {
            string folderPath = "";
            folderPath = string.Format("{0}{1}", rootAppDir, folder);

            return new DirectoryInfo(folderPath);
        }

        public static void MakeSureDirectoryExists(DirectoryInfo path)
        {
            if (!Directory.Exists(path.FullName))
                Directory.CreateDirectory(path.FullName);
        }

        public static class UploadFolers {
            public static string ProfilePhoto { get; } = "Upload/Profiles/";
            public static string PropertyPhoto { get; } = "Upload/Properties/";
            public static string ArticlePhoto { get; } = "Upload/Article/Photos/";
            public static string ArticleVideo { get; } = "Upload/Article/Videos/";
            public static string TenantPhoto { get; } = "Upload/Tenants/";
            public static string ArticleCategoryPhoto { get; } = "Upload/ArticleCategories/";
            public static string ExternalServiceInvoices { get; } = "Upload/ExternalServiceInvoices/";
            public static string ServicePhoto { get; } = "Upload/Services/";
            public static string CategoryItemPhoto { get; } = "Upload/CagegoryItem/";

            public static string StudentPhoto { get; } = "Upload/Students/";
            public static string RoomPhoto { get; } = "Upload/Rooms/";
            public static string PostPhoto { get; } = "Upload/Posts/";

            public static string FoodMenuPhoto { get; } = "Upload/FoodMenu/";
            public static string ImportStudent { get; } = "Upload/ImportStudent/";
            public static string ImportUser { get; } = "Upload/ImportUser/";

            public static string ClassPhoto { get; } = "Upload/Class/";

            public static string ChatMedia { get; } = "Upload/ChatMedia/";
            public static string Resource { get; } = "Upload/Resource/";

            public static string ProductPhoto { get; } = "Upload/ProductPhoto/";
        }

        // public static string GetAbsolutePath(string folder)
        // {
        //     return Statics.DOMAIN + "/" + folder;
        // }

       
    }
}