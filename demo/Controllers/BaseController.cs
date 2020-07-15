using System.Linq;
using System.Net;
using AutoMapper;
using demo.AppCode;
using demo.Helpers;
using Localization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using ImageMagick;
using System;
using System.IO;
using demo.utilities;

namespace demo.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> _logger;
        protected readonly IStringLocalizer<Wording> _sharedLocalizer;
        protected readonly IMapper _mapper;
        public BaseController(ILogger<BaseController> logger, IStringLocalizer<Wording> _sharedLocalizer, IMapper _mapper)
        {
            this._logger = logger;
            this._sharedLocalizer = _sharedLocalizer;
            this._mapper = _mapper;
        }

        protected void Mapping<T, T2>(T cls1, ref T2 cls2)
        {
            cls2 = _mapper.Map<T2>(cls1);
        }

        protected ASPrincipal CurrentUser { get { return new ASPrincipal(User); } }

        protected ActionResult HttpNotFound()
        {
            return StatusCode((int)HttpStatusCode.NotFound);
        }
        protected ActionResult HttpBadRequest()
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        protected ActionResult ExecuateParentPageScript(string functionName = "", RedirectToActionResult action = null)
        {
            var IsPopup = HttpContext.Request.Query["IsPopup"].ToString();
            if (string.IsNullOrEmpty(functionName))
                functionName = HttpContext.Request.Query["Callback"];
            if (IsPopup != null || action == null)
            {
                //string res = string.Format("<script>if(typeof parent.{0} !== 'undefined') parent.{0}(); else parent.utils.CloseIFramePopup();</script><div>Thực hiện thành công.</div>", functionName);
                return View("_Callback", functionName);
            }

            else
                return action;
        }

        protected ActionResult ExecuateParentPageScript(RedirectToActionResult action = null)
        {
            var IsPopup = HttpContext.Request.Query["IsPopup"].ToString() ?? "false";
            string functionName = HttpContext.Request.Query["Callback"];
            if (IsPopup == "true" && string.IsNullOrEmpty(functionName))
                functionName = "ReloadPage";// action;
            if (IsPopup == "true" && !string.IsNullOrEmpty(functionName))
            {
                //string res = string.Format("<script>if(typeof parent.{0} !== 'undefined') parent.{0}(); else parent.utils.CloseIFramePopup();</script><div>Thực hiện thành công.</div>", functionName);
                return View("_Callback", functionName);
            }

            else
                return action;
        }


        #region SaveFile

        private readonly long _fileSizeLimit = 20 * 1024 * 1024;//20MB
        //private readonly string[] _permittedExtensions = { ".png", ".jpg" };
        //private readonly string _targetFilePath;

        public async System.Threading.Tasks.Task<string> SaveFileAsync(IFormFile file, string folderPath)
        {
            var fileInfo = new FileInfo(file.FileName);
            if (FileHelper.DangerFileExts.Contains(fileInfo.Extension.ToLower()))
                ModelState.AddModelError("Files", "Uploaded file do not allowed!");
            var formFileContent = await FileHelpers.ProcessFormFile<IFormFile>(file, ModelState, _fileSizeLimit);

            DirectoryHelper.MakeSureDirectoryExists(new System.IO.DirectoryInfo(folderPath));
            var filePath = FileHelper.GetUniqueFileInfo(new System.IO.DirectoryInfo(folderPath), file.FileName);

            using (var fileStream = System.IO.File.Create(filePath.FullName))
            {
                await fileStream.WriteAsync(formFileContent);
            }

            //resize
            string outputFolder = folderPath + FileHelper.SmallImageFolderName;// "100x100";
            string outputFile = outputFolder + "\\" + filePath.Name;
            DirectoryHelper.MakeSureDirectoryExists(new System.IO.DirectoryInfo(outputFolder));

            try
            {
                if (FileHelper.ImageExts.Contains(filePath.Extension))
                    ResizeImage(filePath.FullName, outputFile, 100, 100);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Files", ex.Message);
            }

            return filePath.Name;

        }


        public string ResizeImage(string inputPath, string outputPath, int size, int quality)
        {
            using (var image = new MagickImage(inputPath))
            {
                image.Resize(size, size);
                image.Strip();
                image.Quality = quality;
                image.Write(outputPath);
                return outputPath;
            }
        }


        #endregion

    }
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
