using Microsoft.AspNetCore.Identity;
using System;

namespace Projeto.Areas.Identity
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public ApplicationUser User { get; set; }
        public Role Role { get; set; }
    }
}
