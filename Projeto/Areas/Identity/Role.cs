using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Projeto.Areas.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public Role() : base() { }

        public Role(string roleName) : base(roleName)
        {
        }

        public override string Name { get => base.Name; set => base.Name = value; }

        public List<UserRole> UserRoles { get; set; }

    }
}
