#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff9b85854bfa32d43f351a6ef117f4025495a43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductColor_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductColor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff9b85854bfa32d43f351a6ef117f4025495a43", @"/Areas/Admin/Views/ProductColor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d65b8c763a49203489a6e9fcd05cdc8b9507f4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductColor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ColorProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
  
    ViewData["Title"] = "رنگ محصول";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        مدیریت
        <small>رنگ ها</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت رنگ ها</li>
    </ol>
</section>


<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 589, "\"", 693, 3);
            WriteAttributeValue("", 596, "/Admin/ProductColor/Create?productid=", 596, 37, true);
#nullable restore
#line 25 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 633, Model.First().ProductId, 633, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 657, "&returnUrl=/Admin/ProductColor/Index", 657, 36, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"><i class=\"fa fa-plus-square\"></i> افزودن رنگ</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff9b85854bfa32d43f351a6ef117f4025495a437663", async() => {
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
                                        <tr role=""row"">

                                            <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" style=""text-align:center;"">
                                                رنگ
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" style=""tex");
            WriteLiteral(@"t-align:center;"">
                                                کد رنگ
                                            </th>
                                            <th></th>

                                            <th style=""text-align:center;"">عملیات</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 50 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
                                         foreach (var item in Model)
                                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr role=\"row\" class=\"odd\">\r\n                                            <td style=\"text-align:center;\">\r\n                                                ");
#nullable restore
#line 56 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ColorPro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"text-align:center;\">\r\n                                                ");
#nullable restore
#line 59 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ColorCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td");
            BeginWriteAttribute("style", " style=\"", 3024, "\"", 3083, 2);
            WriteAttributeValue("", 3032, "text-align:center;background-color:#", 3032, 36, true);
#nullable restore
#line 61 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 3068, item.ColorCode, 3068, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n");
#nullable restore
#line 62 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
                                             if (Model.Count() > 1)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td style=\"text-align:center\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3344, "\"", 3448, 4);
            WriteAttributeValue("", 3351, "/Admin/ProductColor/Delete?productcolorid=", 3351, 42, true);
#nullable restore
#line 66 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 3393, item.ProductColorId, 3393, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3413, "&productid=", 3413, 11, true);
#nullable restore
#line 66 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 3424, Model.First().ProductId, 3424, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\" style=\"color:red; font-size:20px;\"></i></a>\r\n                                                    &nbsp;&nbsp;\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3638, "\"", 3705, 2);
            WriteAttributeValue("", 3645, "/Admin/ProductColor/Edit?productcolorid=", 3645, 40, true);
#nullable restore
#line 68 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 3685, item.ProductColorId, 3685, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\" style=\"color:forestgreen; font-size:20px;\"></i></a>\r\n                                                </td>\r\n");
#nullable restore
#line 70 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td style=\"text-align:center\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 4117, "\"", 4184, 2);
            WriteAttributeValue("", 4124, "/Admin/ProductColor/Edit?productcolorid=", 4124, 40, true);
#nullable restore
#line 75 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
WriteAttributeValue("", 4164, item.ProductColorId, 4164, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\" style=\"color:forestgreen; font-size:20px;\"></i></a>\r\n                                                </td>\r\n");
#nullable restore
#line 77 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 86 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\ProductColor\Index.cshtml"
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
        public IProductColorService productcolorservice { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ColorProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
