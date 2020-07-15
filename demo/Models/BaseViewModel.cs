using System;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        [Display(Name = nameof(CreatedUserId))]
        public int? CreatedUserId { get; set; }
        [Display(Name = nameof(ModifiedUserId))]
        public int? ModifiedUserId { get; set; }
        [Display(Name = nameof(CreatedDate))]
        public DateTime? CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy HH:mm}")]
        [Display(Name = nameof(ModifiedDate))]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = nameof(IsDeleted))]
        public bool? IsDeleted { get; set; }
    }
}