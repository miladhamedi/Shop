#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a647d28b67d3b176509197333c7bc09d1a047f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MessageSendUserAll), @"mvc.1.0.view", @"/Views/Profile/MessageSendUserAll.cshtml")]
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
#line 1 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Galleries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.ShopingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.Core.Service.Services.Weights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\_ViewImports.cshtml"
using Shop.EndPoint.Web.Ui.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a647d28b67d3b176509197333c7bc09d1a047f", @"/Views/Profile/MessageSendUserAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2feb48d13041387f4c41337defd6c7404f988aea", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MessageSendUserAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopActionResult<List<MessageViewModel>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageReply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageSendUserAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
  
    ViewData["Title"] = "پیام های ارسالی";
    ViewData["Breadcromb"] = " پیام های ارسالی";
    var user = User.Identity.Name;
    var AppUser = userservice.GetByUserName(user);
    var listMessAdmin = messageservice.GetAdminMessageRecive(AppUser.Id);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59a647d28b67d3b176509197333c7bc09d1a047f7945", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\'panel_style1\'>\r\n    <div class=\'container\'>\r\n        <div class=\'inner clearfix\'>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59a647d28b67d3b176509197333c7bc09d1a047f9184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""panel_content"">
                <div class=""massage_style1"">
                    <div class=""top_part"">
                        <ul class=""step clearfix none_list_style"">
                            <li class=""item"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a647d28b67d3b176509197333c7bc09d1a047f10587", async() => {
                WriteLiteral("پیام های دریافتی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                  
                                    if (listMessAdmin.Counts > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"count\">\r\n                                            ");
#nullable restore
#line 29 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                       Write(listMessAdmin.Counts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n");
#nullable restore
#line 31 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"count\">\r\n                                            0\r\n                                        </span>\r\n");
#nullable restore
#line 37 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\r\n                            <li class=\"item active\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a647d28b67d3b176509197333c7bc09d1a047f13749", async() => {
                WriteLiteral("پیام های ارسالی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                  
                                    if (Model.Counts > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"count\">\r\n                                            ");
#nullable restore
#line 47 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                       Write(Model.Counts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n");
#nullable restore
#line 49 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"count\">\r\n                                            0\r\n                                        </span>\r\n");
#nullable restore
#line 55 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </li>
                        </ul>
                    </div>
                    <div class=""bottom_part"">
                        <div class=""table2"">
                            <table>
                                <thead>
                                    <tr>
                                        <th class='text-center'>#</th>
                                        <th class='text-center'> پیام</th>
                                        <th class='text-center'>تاریخ ارسال</th>
                                        <th class='text-center'>وضعیت</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 74 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                      
                                        int L = 1;
                                        if (Model.Data.Count() > 0)
                                        {
                                            foreach (var item in Model.Data)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 81 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                   Write(L);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 82 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 83 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                   Write(item.Date.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n");
#nullable restore
#line 85 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                         if (item.Confirm == true)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"read\">خوانده شده</div>\r\n");
#nullable restore
#line 88 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"not_read\">خوانده نشده</div>\r\n");
#nullable restore
#line 92 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 97 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                L = L + 1;
                                            }

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td></td>
                                                <td>شما تاکنون هیچ پیامی ارسال نکرده اید</td>
                                                <td></td>
                                                <td></td>

                                            </tr>
");
#nullable restore
#line 110 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                        <div class=\"pagination_style1\">\r\n                            <nav aria-label=\"...\">\r\n\r\n");
#nullable restore
#line 119 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                 for (int i = 1; i <= Model.Pages; i++)
                                {

                                    if (Model.Page == i)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul class=\"pagination pagination-lg\">\r\n                                            <li class=\"page-item  active\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\'", 5971, "\'", 6024, 2);
            WriteAttributeValue("", 5978, "/Profile/MessageSendUserAll?page=", 5978, 33, true);
#nullable restore
#line 127 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
WriteAttributeValue("", 6011, i.ToString(), 6011, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">");
#nullable restore
#line 127 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                                                                                                    Write(i.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                                            </li>\r\n                                        </ul>\r\n");
#nullable restore
#line 131 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul class=\"pagination pagination-lg\">\r\n                                            <li class=\"page-item \">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\'", 6501, "\'", 6554, 2);
            WriteAttributeValue("", 6508, "/Profile/MessageSendUserAll?page=", 6508, 33, true);
#nullable restore
#line 139 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
WriteAttributeValue("", 6541, i.ToString(), 6541, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">");
#nullable restore
#line 139 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"
                                                                                                                                    Write(i.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                                            </li>\r\n\r\n                                        </ul>\r\n");
#nullable restore
#line 144 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\MessageSendUserAll.cshtml"

                                    }


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </nav>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService userservice { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMessageService messageservice { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopActionResult<List<MessageViewModel>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
