#pragma checksum "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d753b7cee71c87c250c59157230ca3d0d0664aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gorev_PersonelAta), @"mvc.1.0.view", @"/Areas/Admin/Views/Gorev/PersonelAta.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\_ViewImports.cshtml"
using İşTakipProjesi;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d753b7cee71c87c250c59157230ca3d0d0664aa9", @"/Areas/Admin/Views/Gorev/PersonelAta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddb07b69f6eee06dfad9ab364374fa14b49f63e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gorev_PersonelAta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<İşTakipProjesi.Areas.Admin.Models.GorevUsersVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-toast-plugin/jquery.toast.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("card image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/person.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-toast-plugin/jquery.toast.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-loading-overlay/loadingoverlay.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.CompletedGorevCountTagHelper __İşTakipProjesi_Areas_Admin_CustomTagHelpers_CompletedGorevCountTagHelper;
        private global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.UncompletedGorevCountTagHelper __İşTakipProjesi_Areas_Admin_CustomTagHelpers_UncompletedGorevCountTagHelper;
        private global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.RaporCountTagHelper __İşTakipProjesi_Areas_Admin_CustomTagHelpers_RaporCountTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
  
    ViewData["Title"] = "PersonelAta";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d753b7cee71c87c250c59157230ca3d0d0664aa96475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    /* FontAwesome for working BootSnippet :> */
    .loading {
        background: rgba(0, 0, 0, 0.3);
        bottom: 0;
        left: 0;
        position: fixed;
        right: 0;
        top: 0;
        z-index: 9998;
    }

    .spinner {
        background: #000 url(https://code.jquery.com/mobile/1.1.0/images/ajax-loader.gif) 0 0 no-repeat;
        border: 0;
        -webkit-border-radius: 36px;
        -moz-border-radius: 36px;
        border-radius: 36px;
        box-shadow: 0 1px 1px -1px #fff;
        display: block;
        height: 46px;
        left: 50%;
        margin: -23px 0 0 -23px;
        opacity: 0.18;
        overflow: hidden;
        padding: 1px;
        position: fixed;
        text-align: center;
        top: 50%;
        width: 46px;
        z-index: 9999;
    }


    #team {
        background: #eee !important;
    }

    .btn-primary:hover,
    .btn-primary:focus {
        background-color: #108d6f;
        border-color: #108d6f;
");
            WriteLiteral(@"        box-shadow: none;
        outline: none;
    }

    .btn-primary {
        color: #fff;
        background-color: #007b5e;
        border-color: #007b5e;
    }

    section {
        padding: 60px 0;
    }

        section .section-title {
            text-align: center;
            color: #007b5e;
            margin-bottom: 50px;
            text-transform: uppercase;
        }

    #team .card {
        border: none;
        background: #ffffff;
    }

    .image-flip:hover .backside,
    .image-flip.hover .backside {
        -webkit-transform: rotateY(0deg);
        -moz-transform: rotateY(0deg);
        -o-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        transform: rotateY(0deg);
        border-radius: .25rem;
    }

    .image-flip:hover .frontside,
    .image-flip.hover .frontside {
        -webkit-transform: rotateY(180deg);
        -moz-transform: rotateY(180deg);
        -o-transform: rotateY(180deg);
        transform: rotateY(1");
            WriteLiteral(@"80deg);
    }

    .mainflip {
        -webkit-transition: 1s;
        -webkit-transform-style: preserve-3d;
        -ms-transition: 1s;
        -moz-transition: 1s;
        -moz-transform: perspective(1000px);
        -moz-transform-style: preserve-3d;
        -ms-transform-style: preserve-3d;
        transition: 1s;
        transform-style: preserve-3d;
        position: relative;
    }

    .frontside {
        position: relative;
        -webkit-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        z-index: 2;
        margin-bottom: 30px;
    }

    .backside {
        position: absolute;
        top: 0;
        left: 0;
        background: white;
        -webkit-transform: rotateY(-180deg);
        -moz-transform: rotateY(-180deg);
        -o-transform: rotateY(-180deg);
        -ms-transform: rotateY(-180deg);
        transform: rotateY(-180deg);
        -webkit-box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        -moz-box-shadow: 5px 7px 9px -4px");
            WriteLiteral(@" rgb(158, 158, 158);
        box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
    }

    .frontside,
    .backside {
        -webkit-backface-visibility: hidden;
        -moz-backface-visibility: hidden;
        -ms-backface-visibility: hidden;
        backface-visibility: hidden;
        -webkit-transition: 1s;
        -webkit-transform-style: preserve-3d;
        -moz-transition: 1s;
        -moz-transform-style: preserve-3d;
        -o-transition: 1s;
        -o-transform-style: preserve-3d;
        -ms-transition: 1s;
        -ms-transform-style: preserve-3d;
        transition: 1s;
        transform-style: preserve-3d;
    }

        .frontside .card,
        .backside .card {
            min-height: 150px;
            width: 250px !important;
        }

            .backside .card a {
                font-size: 18px;
                color: #007b5e !important;
            }

            .frontside .card .card-title,
            .backside .card .card-title {
            ");
            WriteLiteral(@"    color: #007b5e !important;
            }

            .frontside .card .card-body img {
                width: 120px;
                height: 120px;
                border-radius: 50%;
            }
</style>

<div class=""loading"" style=""display: none;"">
    <div class=""spinner""></div>
    <div id=""alerts"" class=""text-center""></div>
</div>
<div class=""loading"" id=""LoadingElement"" style=""display: none;"">
</div>
<div class=""text-center"">
    <h4 style=""color: #858796;"">Personel Ata</h4>
    <hr />
</div>

<div class=""text-center"">
    <div class=""card shadow mb-4 d-inline-block"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">");
#nullable restore
#line 185 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                                     Write(Model.gorev.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            ");
#nullable restore
#line 189 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
       Write(Model.gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n<section id=\"team\" class=\" py-0\">\r\n    <div class=\"container\">\r\n        <h5 class=\"section-title mb-2 h4 pt-5\"><b>Personeller</b></h5>\r\n\r\n\r\n        <div class=\"row\">\r\n            <!-- Team member -->\r\n");
#nullable restore
#line 204 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
             foreach (var item in Model.users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-xs-12 col-sm-6 col-md-3 "">
                    <div class=""image-flip"" ontouchstart=""this.classList.toggle('hover');"">
                        <div class=""mainflip"">
                            <div class=""frontside"">
                                <div class=""card text-center"">
                                    <div class=""card-body d-inline-block"">
");
#nullable restore
#line 212 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                         if (item.ResimUrl != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d753b7cee71c87c250c59157230ca3d0d0664aa914602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6049, "~/img/", 6049, 6, true);
#nullable restore
#line 214 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
AddHtmlAttributeValue("", 6055, item.ResimUrl, 6055, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 215 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d753b7cee71c87c250c59157230ca3d0d0664aa916710", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 219 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <h4 class=\"card-title\"");
            BeginWriteAttribute("id", " id=\"", 6452, "\"", 6471, 2);
            WriteAttributeValue("", 6457, "user", 6457, 4, true);
#nullable restore
#line 221 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
WriteAttributeValue("", 6461, item.Id, 6461, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 221 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                                                               Write(item.Ad+" "+item.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""backside"">
                                <div class=""card"">
                                    <div class=""card-body text-center mt-4"">
                                        <h4 class=""card-title"">");
#nullable restore
#line 230 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                                                           Write(item.Ad+" "+item.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p class=\"card-text\">\r\n                                            Tamamladığı Görevler : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("completedgorevcounttaghelper", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d753b7cee71c87c250c59157230ca3d0d0664aa919955", async() => {
            }
            );
            __İşTakipProjesi_Areas_Admin_CustomTagHelpers_CompletedGorevCountTagHelper = CreateTagHelper<global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.CompletedGorevCountTagHelper>();
            __tagHelperExecutionContext.Add(__İşTakipProjesi_Areas_Admin_CustomTagHelpers_CompletedGorevCountTagHelper);
#nullable restore
#line 232 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
__İşTakipProjesi_Areas_Admin_CustomTagHelpers_CompletedGorevCountTagHelper.UserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("user-id", __İşTakipProjesi_Areas_Admin_CustomTagHelpers_CompletedGorevCountTagHelper.UserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n                                            Devam Eden Görevler :  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("uncompletedgorevcounttaghelper", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d753b7cee71c87c250c59157230ca3d0d0664aa921572", async() => {
            }
            );
            __İşTakipProjesi_Areas_Admin_CustomTagHelpers_UncompletedGorevCountTagHelper = CreateTagHelper<global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.UncompletedGorevCountTagHelper>();
            __tagHelperExecutionContext.Add(__İşTakipProjesi_Areas_Admin_CustomTagHelpers_UncompletedGorevCountTagHelper);
#nullable restore
#line 233 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
__İşTakipProjesi_Areas_Admin_CustomTagHelpers_UncompletedGorevCountTagHelper.UserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("user-id", __İşTakipProjesi_Areas_Admin_CustomTagHelpers_UncompletedGorevCountTagHelper.UserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n                                            Yazdığı Rapor Sayısı : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("raporcounttaghelper", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d753b7cee71c87c250c59157230ca3d0d0664aa923201", async() => {
            }
            );
            __İşTakipProjesi_Areas_Admin_CustomTagHelpers_RaporCountTagHelper = CreateTagHelper<global::İşTakipProjesi.Areas.Admin.CustomTagHelpers.RaporCountTagHelper>();
            __tagHelperExecutionContext.Add(__İşTakipProjesi_Areas_Admin_CustomTagHelpers_RaporCountTagHelper);
#nullable restore
#line 234 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
__İşTakipProjesi_Areas_Admin_CustomTagHelpers_RaporCountTagHelper.UserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("user-id", __İşTakipProjesi_Areas_Admin_CustomTagHelpers_RaporCountTagHelper.UserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </p>\r\n                                        <button class=\"btn text-white bg-gradient-danger btn-sm gorevAta\"");
            BeginWriteAttribute("id", " id=\"", 7701, "\"", 7716, 1);
#nullable restore
#line 236 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
WriteAttributeValue("", 7706, item.Id, 7706, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Görevi Ata</button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 243 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- ./Team member -->

        </div>



    </div>
</section>


<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""myModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Uyarı</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p id=""modalText""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""Ata"">Ata</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" id=""Kapat"">Kapat</button>
            </div>
        </div>
    </div>
</div>
<div class=""alert alert-info fade in"" id=""bsalert"">
    <a href=""#"" class=""close"" data-dismiss=""alert");
            WriteLiteral("\" aria-label=\"close\">&times;</a>\r\n    <strong>Info!</strong> This alert box could indicate a neutral informative or action\r\n</div>\r\n<div class=\"loading\" id=\"LoadingElement\" style=\"display: none;\"></div>\r\n<!-- Team -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d753b7cee71c87c250c59157230ca3d0d0664aa927182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d753b7cee71c87c250c59157230ca3d0d0664aa928282", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(\".gorevAta\").click(function () {\r\n\r\n            var gorevId = ");
#nullable restore
#line 286 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\PersonelAta.cshtml"
                      Write(Model.gorev.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            console.log(""gorev id:"" + gorevId);
            var userId = this.id;
            console.log(""user id:"" + userId);
            var userName = $('#user' + userId).text();
            console.log(""username :"" + userName);
            $(""#modalText"").text(""Görevi "" + userName + "" adlı personele atamak istediğinize emin misiniz?"");
            $('#myModal').show();

            $(""#Ata"").click(function () {
                $('#myModal').hide();
                $("".loading"").toggle();

                //$(""#LoadingElement"").show();
                //$(""#LoadingElement"").LoadingOverlay(""show"", {
                //    background: ""rgba(16, 16, 16, 0.5)""
                //});
                $.ajax(
                    {
                        type: ""POST"",
                        url: ""{area=Admin,action=PersonelAta,controller=Gorev}"",
                        data: { gorevId, userId },
                        success: function (data) {
                            console.log(da");
                WriteLiteral(@"ta);
                            var obj = JSON.parse(JSON.stringify(data))
                            obj.durum = new Boolean(obj.success);

                            if (obj.durum == true) {

                                $(""#alerts"").append(""<div class='alert alert-success'>"" +
                                    ""<strong>Atama Başarılı !</strong></div >"");
                                setTimeout(function () {
                                    
                                    
                                    $("".loading"").hide();
                                    
                                    window.location.href = ""/Admin/Gorev/Gorevler"";
                                }, 5000);
                            }
                            else {
                                $(""#alerts"").append(""<div class='alert alert-danger'>"" +
                                    ""<strong>Atama Başarısız !</strong></div >"");
                                
               ");
                WriteLiteral(@"                 setTimeout(function () {
                                    
                                    
                                    $("".loading"").hide();
                                }, 5000);
                            }

                            setTimeout(function () {
                                $("".loading"").hide();
                                //$(""#LoadingElement"").hide();
                            }, 2000);

                        }
                    });
            });

            $(""#Kapat"").click(function () {
                $('#myModal').hide();
            });

           

        });
        function ModifyHtml() {
            setTimeout(function () {

            }, 2000);
        }
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<İşTakipProjesi.Areas.Admin.Models.GorevUsersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
