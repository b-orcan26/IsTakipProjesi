using Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Admin.CustomTagHelpers
{
    [HtmlTargetElement("raporcounttaghelper")]
    public class RaporCountTagHelper : TagHelper
    {
        public int UserId { get; set; }
        private readonly IRaporService raporManager;

        public RaporCountTagHelper(IRaporService _raporManager)
        {
            raporManager = _raporManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            int count = raporManager.RaporCountByUserId(UserId);
            output.Content.SetHtmlContent(count.ToString());
            base.Process(context, output);
        }
    }
}
