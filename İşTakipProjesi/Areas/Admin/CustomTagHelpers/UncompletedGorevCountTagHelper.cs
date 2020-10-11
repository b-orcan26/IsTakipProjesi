using Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Admin.CustomTagHelpers
{
    [HtmlTargetElement("uncompletedgorevcounttaghelper")]
    public class UncompletedGorevCountTagHelper : TagHelper
    {
        public int UserId { get; set; }
        private readonly IGorevService gorevManager;

        public UncompletedGorevCountTagHelper(IGorevService _gorevManager)
        {
            gorevManager = _gorevManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            int count = gorevManager.UncompletedGorevCountByUserId(UserId);
            output.Content.SetHtmlContent(count.ToString());
            base.Process(context, output);
        }
    }
}
