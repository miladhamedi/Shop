#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Shared\_CountCommentsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9847689d98608200f2d64d6cca6756bac4f619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__CountCommentsPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_CountCommentsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9847689d98608200f2d64d6cca6756bac4f619", @"/Areas/Admin/Views/Shared/_CountCommentsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d65b8c763a49203489a6e9fcd05cdc8b9507f4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__CountCommentsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box"">
        <span class=""info-box-icon bg-red""><i class=""fa fa-google-plus""></i></span>
        <div class=""info-box-content"">
            <span class=""info-box-text"" style=""text-align: center;padding: 10px;"">تعداد نظرات </span>
            <span class=""info-box-number"" style=""text-align: center;"">");
#nullable restore
#line 9 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Shared\_CountCommentsPartial.cshtml"
                                                                 Write(profileindexservice.GetAllComment().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("<small>&nbsp;&nbsp;عدد</small></span>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProfileIndexService profileindexservice { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
