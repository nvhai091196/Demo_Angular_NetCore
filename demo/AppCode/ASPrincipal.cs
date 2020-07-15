using System.Linq;
using System.Security.Claims;

namespace demo.AppCode
{
    public class ASPrincipal
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public bool IsSysAdmin { get; set; }
        public string Roles { get; set; }
        public ASPrincipal(ClaimsPrincipal user)
        {
            this.Id = int.Parse(user.Claims.FirstOrDefault(m => m.Type == nameof(Id))?.Value ?? "0");
            this.IsSysAdmin = (user.Claims.FirstOrDefault(m => m.Type == nameof(IsSysAdmin))?.Value ?? false.ToString()) == true.ToString();
            this.FullName = user.Claims.FirstOrDefault(m => m.Type == nameof(FullName))?.Value ?? "";
            this.Roles = user.Claims.FirstOrDefault(m => m.Type == nameof(Roles))?.Value ?? "";
        }
    }
    public class ASPrincipalModel 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public bool IsSysAdmin { get; set; }
        public string Roles { get; set; }
    }
}