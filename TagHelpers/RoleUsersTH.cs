﻿using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.TagHelpers
{
    [HtmlTargetElement("td", Attributes ="i-role")]
    public class RoleUsersTH:TagHelper
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleUsersTH(UserManager<ApplicationUser> usrmgr, RoleManager<IdentityRole> rlMgr)
        {
            _userManager = usrmgr;
            _roleManager = rlMgr;
        }

        [HtmlAttributeName("i-role")]
        public string Role { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            IdentityRole role = await _roleManager.FindByIdAsync(Role);
            if(role != null)
            {
                foreach(var user in _userManager.Users)
                {
                    if (user != null && await _userManager.IsInRoleAsync(user, role.Name))
                        names.Add(user.FirstName + " " + user.LastName);
                }
            }
            output.Content.SetContent(names.Count == 0 ? "No Ussers" : string.Join(", ", names));
        }

    }
}
