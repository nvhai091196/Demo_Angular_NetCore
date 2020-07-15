using System;

namespace demo.domain.Models.Administration
{
    public class User: BaseModel
    {
          public string  UserName { get; set; }


public string  FullName { get; set; }


public string  Email { get; set; }


public string  Address { get; set; }


public string  Mobile { get; set; }


public bool? Status { get; set; }


public bool? IsAdmin { get; set; }


public string  LANG { get; set; }


public string  StypeId { get; set; }


public string  About { get; set; }


public string  FacebookUrl { get; set; }


public string  TwiterUrl { get; set; }


public DateTime? DateOfBirth { get; set; }


public string  SocialNo { get; set; }


public DateTime? SocialRegisterDate { get; set; }


public string  SocialRegisterProvince { get; set; }


public string  PermanentAddress { get; set; }


public string  Photo { get; set; }


public string  FCMToken { get; set; }



//[FieldTemplates]
    }
}