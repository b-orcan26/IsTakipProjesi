#pragma checksum "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df478ac627f838d71af5036e7d4a2612ea17737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gorev_Raporlar), @"mvc.1.0.view", @"/Areas/Admin/Views/Gorev/Raporlar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7df478ac627f838d71af5036e7d4a2612ea17737", @"/Areas/Admin/Views/Gorev/Raporlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddb07b69f6eee06dfad9ab364374fa14b49f63e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gorev_Raporlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTO.RaporListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-toast-plugin/jquery.toast.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-toast-plugin/jquery.toast.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-loading-overlay/loadingoverlay.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
  
    ViewData["Title"] = "Raporlar";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7df478ac627f838d71af5036e7d4a2612ea177374912", async() => {
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
    .loading {
        background: rgba(0, 0, 0, 0.3);
        bottom: 0;
        left: 0;
        position: fixed;
        right: 0;
        top: 0;
        z-index: 9998;
    }
</style>
<div class=""loading"" id=""LoadingElement"" style=""display: none;"">
</div>
<div class=""text-center"">
    <h4>Raporlar</h4>
    <hr />
</div>
<div class=""row align-items-stretch"">
");
#nullable restore
#line 27 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark border-bottom-dark mb-3  col-4 mx-2\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header  text-right\"><small class=\"text-muted\"> Tarih : ");
#nullable restore
#line 30 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
                                                                                Write(item.YazilmaTarihi.ToString("MM/dd/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></div>\r\n            <div class=\"card-body\">\r\n\r\n                <p class=\"card-text\">");
#nullable restore
#line 33 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
                                Write(Html.Raw(item.Icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer text-right\">\r\n");
#nullable restore
#line 36 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
                 if (item.Okundumu == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Okundu</p>\r\n");
#nullable restore
#line 39 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 1287, "\"", 1302, 1);
#nullable restore
#line 42 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
WriteAttributeValue("", 1292, item.Id, 1292, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger d-block checkedBtn\">Okundu Olarak İşaretle</button>\r\n");
#nullable restore
#line 43 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Baris\source\YeniSayfa\is takibi dapper\İşTakipProjesi\İşTakipProjesi\Areas\Admin\Views\Gorev\Raporlar.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7df478ac627f838d71af5036e7d4a2612ea177379540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7df478ac627f838d71af5036e7d4a2612ea1773710639", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        $("".checkedBtn"").click(function () {


            $(""#LoadingElement"").show();
            $(""#LoadingElement"").LoadingOverlay(""show"", {
                background: ""rgba(16, 16, 16, 0.5)""
            });
            var id = this.id;
            var isSuccess = AjaxWork(id);
            console.log(""ajax return :"" + isSuccess);

            function AjaxWork(id) {
                var isSuccess = false;

                $.ajax(
                    {
                        type: ""GET"",
                        url: ""/Admin/Rapor/OkunduOlarakIsaretle/"",
                        data: { id },
                        async: false,
                        success: function (data) {

                            var obj = JSON.parse(JSON.stringify(data))
                            obj.durum = new Boolean(obj.success);


                            if (obj.durum == true) {

                                setTimeout(function () {
           ");
                WriteLiteral(@"                         //var parent = $("".checkedBtn#"" + id).parent();
                                    //parent.append(""<p>Okundu</p>"");

                                    $(""#LoadingElement"").hide();
                                    $.toast({
                                        heading: 'Başarılı',
                                        text: 'Rapor okundu olarak işaretlendi',
                                        showHideTransition: 'slide',
                                        icon: 'success'
                                    })
                                }, 2000);
                                ModifyHtml();
                            }
                            else {
                                isSuccess = false;
                                setTimeout(function () {
                                    $(""#LoadingElement"").hide();

                                    $.toast({
                                        heading: 'Hata',
             ");
                WriteLiteral(@"                           text: 'Rapor okundu olarak işaretlenemedi',
                                        showHideTransition: 'fade',
                                        icon: 'error'
                                    })
                                }, 2000);
                            }
                        },
                        error: function (request, status, error) {

                            $(""#LoadingElement"").hide();
                            alert(request.responseText);
                        }
                    });

            }

            function ModifyHtml() {
                setTimeout(function () {
                    var parent = $("".checkedBtn#"" + id).parent();
                    parent.append(""<p>Okundu</p>"");
                    $("".checkedBtn#"" + id).remove();
                }, 2000);

            }





        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTO.RaporListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
