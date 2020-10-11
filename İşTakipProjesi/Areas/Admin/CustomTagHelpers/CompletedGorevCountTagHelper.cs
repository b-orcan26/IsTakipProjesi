using Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Admin.CustomTagHelpers
{
    [HtmlTargetElement("completedgorevcounttaghelper")]
    public class CompletedGorevCountTagHelper : TagHelper
    {
        public int UserId { get; set; }
        private readonly IGorevService gorevManager;

        public CompletedGorevCountTagHelper(IGorevService _gorevManager)
        {
            gorevManager = _gorevManager;
        }        

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            int count = gorevManager.CompletedGorevCountByUserId(UserId);
            output.Content.SetHtmlContent(count.ToString());
            base.Process(context, output);
        }
    }
}
