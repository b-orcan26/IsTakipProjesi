using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Personel.CustomTagHelpers
{
    [HtmlTargetElement("GorevInfo")]
    public class GorevInfoByRaporIdTagHelper : TagHelper
    {
        public int RaporId { get; set; }
        private readonly IGorevService gorevManager;

        public GorevInfoByRaporIdTagHelper(IGorevService _gorevManager)
        {
            gorevManager = _gorevManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var gorev = gorevManager.GetGorevByRaporId(RaporId).Result;
            string str ="<p class='d-inline'>"+gorev.Tanim+"</p>";
            output.Content.SetHtmlContent(str);
            base.Process(context, output);
        }
    }
}
