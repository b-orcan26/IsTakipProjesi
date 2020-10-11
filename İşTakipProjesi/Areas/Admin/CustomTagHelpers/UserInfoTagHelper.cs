using Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Admin.CustomTagHelpers
{
    [HtmlTargetElement("UserInfo")]
    public class UserInfoTagHelper : TagHelper
    {
        private readonly IUserService userManager;

        public string UserName { get; set; }

        public UserInfoTagHelper(IUserService _userManager)
        {
            userManager = _userManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            var user = userManager.GetUserByUsername(UserName).Result;
            string userFullName = user.Ad + " " + user.Soyad;
            string resimYolu = "/img/";
            if (user.ResimUrl == null)
            {
                resimYolu += "person.png";
            }
            else
            {
                resimYolu += user.ResimUrl;
            }

            output.Content.SetHtmlContent("<span class='mr-2 d-none d-lg-inline text-gray-600 small'>"+userFullName+"</span><img class='img-profile rounded-circle' src='"+ resimYolu +"'");
            base.Process(context, output);
        }
    }
}
