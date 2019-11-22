using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Projeto.Areas.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public override string Email { get => base.Email; set => base.Email = value; }
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JwtToken { get; set; }        
        public DateTime? DateLastLogin { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
