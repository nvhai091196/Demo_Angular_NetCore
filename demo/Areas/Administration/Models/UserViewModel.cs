using System;
using System.ComponentModel.DataAnnotations;
using demo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace demo.Areas.Administration.Models
{
    public class UserViewModel : BaseViewModel
    {

        [Display(Name = nameof(UserName))]
        public string UserName { get; set; }




        [Display(Name = nameof(FullName))]
        public string FullName { get; set; }




        [Display(Name = nameof(Email))]
        public string Email { get; set; }




        [Display(Name = nameof(Address))]
        public string Address { get; set; }




        [Display(Name = nameof(Mobile))]
        public string Mobile { get; set; }




        [Display(Name = nameof(Status))]
        public bool? Status { get; set; }




        [Display(Name = nameof(IsAdmin))]
        public bool? IsAdmin { get; set; }




        [Display(Name = nameof(LANG))]
        public string LANG { get; set; }




        [Display(Name = nameof(StypeId))]
        public string StypeId { get; set; }




        [Display(Name = nameof(About))]
        public string About { get; set; }




        [Display(Name = nameof(FacebookUrl))]
        public string FacebookUrl { get; set; }




        [Display(Name = nameof(TwiterUrl))]
        public string TwiterUrl { get; set; }




        [Display(Name = nameof(DateOfBirth))]
        public DateTime? DateOfBirth { get; set; }




        [Display(Name = nameof(SocialNo))]
        public string SocialNo { get; set; }




        [Display(Name = nameof(SocialRegisterDate))]
        public DateTime? SocialRegisterDate { get; set; }




        [Display(Name = nameof(SocialRegisterProvince))]
        public string SocialRegisterProvince { get; set; }




        [Display(Name = nameof(PermanentAddress))]
        public string PermanentAddress { get; set; }




        [Display(Name = nameof(Photo))]
        public string Photo { get; set; }




        [Display(Name = nameof(FCMToken))]
        public string FCMToken { get; set; }




        //[FieldTemplates]
    }
}