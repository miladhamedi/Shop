#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Manage\Notfound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e0423d646c6b6ffb58a1858a958b7741644ea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Notfound), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Notfound.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e0423d646c6b6ffb58a1858a958b7741644ea3", @"/Areas/Admin/Views/Manage/Notfound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d65b8c763a49203489a6e9fcd05cdc8b9507f4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Notfound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Areas\Admin\Views\Manage\Notfound.cshtml"
  

    ViewData["Title"] = "مدیریت خطا ها";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    th, td {
        text-align: center;
    }

    .even {
        background-color: white;
    }

    .odd {
        background-color: #ebebeb;
    }
</style>
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        مدیریت
        <small>خطا ها</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت خطا ها  </li>
    </ol>
</section>
<!-- Main content -->

<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">

                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <div id=""example2_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
                        <div class=""row""><div class=""col-sm-6""></div><div class=""col-sm-6""></div></div>
                        <div class=""r");
            WriteLiteral(@"ow"">
                            <div class=""col-sm-12"">



                                <table id=""example2"" class=""table table-bordered table-hover dataTable"" role=""grid"" aria-describedby=""example2_info"">
                                    <thead>
                                        <tr></tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style=""text-align:center;"" class=""alert alert-info"">
                                                <span> کاربرگرامی عملیات نا موفق بود!!</span>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>


                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <!-- /.box-body -->
        </div");
            WriteLiteral(">\r\n        <!-- /.box -->\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n<!-- /.content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591