#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gallery_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Gallery/Index.cshtml")]
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
#line 1 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Galleries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.UserPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.ProductColors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25a7ad1e8d6848f4962b69b48719ca2aa42b7e9", @"/Areas/Admin/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d65b8c763a49203489a6e9fcd05cdc8b9507f4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GalleryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
  

    ViewData["Title"] = "تصویر محصول";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""content-header"">
    <h1>

        <small>تصویر محصول</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">تصویر محصول</li>
    </ol>
</section>



<section class=""content"">

    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <a");
            BeginWriteAttribute("href", " href=\'", 539, "\'", 633, 3);
            WriteAttributeValue("", 546, "/Admin/Gallery/Create?productid=", 546, 32, true);
#nullable restore
#line 31 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 578, Model.First().ProductId, 578, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 602, "&returnUrl=/Admin/Gallery/Index", 602, 31, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\"><i class=\"fa fa-plus-square\"></i> افزودن  تصویر</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e99407", async() => {
                WriteLiteral("<i class=\"fa fa-backward\"></i>  برگشت ب لیست محصولات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""box-body"">
                    <div id=""example2_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
                        <div class=""row""><div class=""col-sm-6""></div><div class=""col-sm-6""></div></div>
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <table id=""example2"" class=""table table-bordered table-hover dataTable"" role=""grid"" aria-describedby=""example2_info"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">
                                               تصویر محصول
                                            </th>
                                            <th class=""text-center"">
                                               نام محصول
                                            </th>
                                            <th clas");
            WriteLiteral("s=\"text-center\">ویرایش </th>\r\n                                            <th class=\"text-center\"> حذف</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 54 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td class=""text-center"">

                                                    <div class=""form-horizontal""> 
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e912813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2516, "~/uploads/Products/", 2516, 19, true);
#nullable restore
#line 60 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
AddHtmlAttributeValue("", 2535, item.PictureName, 2535, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
AddHtmlAttributeValue("", 2584, item.Titel, 2584, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>
                                                   
                                                </td>
                                                <td class=""text-center"">
                                                    ");
#nullable restore
#line 65 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
#nullable restore
#line 67 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                 if (item.Default == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align:center\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e916030", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" style=\"color:forestgreen; font-size:20px;\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-galleryid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                                                                               WriteLiteral(item.GalleryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-galleryid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        &nbsp;&nbsp;\r\n                                                    </td>\r\n");
#nullable restore
#line 73 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"text-align:center\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e919179", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" style=\"color:forestgreen; font-size:20px;\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-galleryid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                                                                               WriteLiteral(item.GalleryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-galleryid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        &nbsp;&nbsp;

                                                    </td>
                                                    <td style=""text-align:center"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a7ad1e8d6848f4962b69b48719ca2aa42b7e921978", async() => {
                WriteLiteral("<i class=\"fa fa-trash\" style=\"color:red; font-size:20px;\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-galleryid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                                                                                 WriteLiteral(item.GalleryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-galleryid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["galleryid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        &nbsp;&nbsp;\r\n                                                    </td>\r\n");
#nullable restore
#line 85 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </tr>\r\n");
#nullable restore
#line 88 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Gallery\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </div>


                </div>

            </div>

        </div>
    </div>
</section>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GalleryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
