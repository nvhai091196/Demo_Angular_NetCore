using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace demo.utilities
{
    public class FileHelper
    {

        public static string SmallImageFolderName { get; } = "100x100";
        public static string MediumImageFolderName { get; } = "1000x1000";
        public static string DefaultProfileImage { get; } = "Content/img/default_profile.jpg";
        public static string DefaultImage { get; } = "Content/img/placeholder.png";
        public static string DefaultFolderImage { get; } = "Content/img/folder.png";
        public static string[] ImageExts { get; } = new string[] { ".jpg", ".png", ".gif", ".jpeg" };
        public static string[] VideoExts { get; } = new string[] { ".mkv", ".ogv", ".avi", ".wmv", ".asf", ".mp4",".m4p", ".m4v", ".mpeg",".mpg", ".mpe", ".mpv", ".mpg", ".m2v" };
        public static string[] DangerFileExts { get; } = new string[] { 
            ".exe", ".jar", ".pif", ".application", 
            ".gadget", ".msi", ".msp", ".com", ".scr", 
            ".hta",".cpl",".cpl",".msc",".bat",".vb",".vbs",".vbe",".js",
            ".jse", ".ws", ".wsf",".wsc", ".wsf", ".wsc", ".wsh", ".ps1", 
            ".ps1xml", ".ps2", ".ps2xml", ".psc1",".psc2",
            ".msh", ".msh1",".msh2", ".mshxml", ".msh1xml", ".msh2xml",
            ".scf", ".lnk", ".inf", ".reg"};
        public static FileInfo GetUniqueFileInfo(DirectoryInfo dir, string fileName)
        {
            DirectoryHelper.MakeSureDirectoryExists(dir);
            //chua xong
            var filePath = dir.FullName +"\\"+ fileName;
            var fileInfo = new FileInfo(filePath);
            int index = 1;
            while (fileInfo.Exists)
            {
                fileInfo = new FileInfo(filePath.Replace(fileInfo.Extension, string.Format("({0}){1}",index++,fileInfo.Extension)));
            }

            return fileInfo;
        }
    }
}
