using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using demo.Areas.Administration.Models;
using demo.Controllers;
using demo.domain.Models.Administration;
using demo.domain.Services.Administration;
using Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace demo.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class UserController : BaseController
    {
        private readonly IUserService service;
        public UserController(ILogger<BaseController> logger, IStringLocalizer<Wording> _sharedLocalizer, IMapper _mapper
        , IUserService _service) : base(logger, _sharedLocalizer, _mapper)
        {
            this.service = _service;
        }
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult IndexGrid(string SearchKey)
        {
            SearchKey = SearchKey ?? "";
            var models = new List<UserViewModel>();
            var Users = service.Get();
            Mapping(Users, ref models);
            return PartialView("_IndexGrid", models);
        }

        public ActionResult Details(int Id)
        {
            var model = new UserViewModel();
            var User= service.Get(Id);
            if (User== null)
                return HttpNotFound();
            Mapping(User, ref model);
            return View(model);
        }
        private void GetViewData(UserViewModel model)
        {
        }

        public ActionResult Create()
        {
            var model = new UserViewModel();
            GetViewData(model);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var User = new User();
                Mapping(model, ref User);

                User.SetModifier(CurrentUser.Id);
                if (service.Create(User))
                    return ExecuateParentPageScript(RedirectToAction("Index"));
            }
            GetViewData(model);
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var User = service.Get(id);
            if (User== null)
                return HttpNotFound();
            var model = new UserViewModel();
            Mapping(User, ref model);
            GetViewData(model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var User= service.Get(model.Id);
                if (User== null)
                    return HttpNotFound();
                User.SetUpdateModifier(CurrentUser.Id);
                if (service.Update(User))
                    return ExecuateParentPageScript(RedirectToAction("Index"));
            }
            GetViewData(model);
            return View(model);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return HttpBadRequest();

             var User= service.Get((int)id);
            if (User == null)
                return HttpNotFound();

            return View(User);
        }
 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var User = service.Get(id);
            if (User== null)
                return HttpNotFound();
            User.SetDeleteModifier(CurrentUser.Id);
            service.Update(User);
            return ExecuateParentPageScript(RedirectToAction("Index"));
        }
       [HttpPost]
        public ActionResult DeleteRange(List<int> Selected)
        {
            if (Selected != null)
                service.DeleteRange(Selected);
            return ExecuateParentPageScript(RedirectToAction("Index"));
        }
    }
}