#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8be6f9752cee6edfe9a9d4759a647776ea590d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa8be6f9752cee6edfe9a9d4759a647776ea590d", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2feb48d13041387f4c41337defd6c7404f988aea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact_frm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "تماس با ما";
    ViewData["Breadcromb"] = "درباره ما";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa8be6f9752cee6edfe9a9d4759a647776ea590d6914", async() => {
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
            WriteLiteral(@"

    <div class='contact_part1'>
        <div class='top_part'>
            <div class='container'>
                <div class='inner clearfix'>
                    <div class='left_part'>
                        <div class='title_style7'>
                            <div class='title'>راه های ارتباطی</div>
                            <div class='sub_title'>
                                از طریق راه های ارتباطی زیر یا ارسال تیکت میتوانید با ما در ارتباط باشید.
                            </div>
                        </div><!--close .title_style7-->
                        <div class='info_style1'>
                            <ul class='step none_list_style clearfix'>
                                <li class='item'>
                                    <div class='icon'><i class='i-telephone'></i></div>
                                    <div class='content'>0000</div>
                                </li>
                                <li class='item'>
                             ");
            WriteLiteral(@"       <div class='icon'><i class='i-mail'></i></div>
                                    <div class='content'>info@kiket.ir</div>
                                </li>
                            </ul><!--close .step-->
                        </div><!--close .info_style1-->
                    </div><!--close .left_part-->
                    <div class='right_part'>
                        <div class='form_style2'>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8be6f9752cee6edfe9a9d4759a647776ea590d9542", async() => {
                WriteLiteral(@"
                                <input type=""hidden"" name=""_token"" value=""KubHdUwJNAhD3EiMO7ancz5OGMtQTMwekpJlr53n"">
                                <ul class='step none_list_style'>
                                    <li class='item'>
                                        <div class='icon'><i class='i-user'></i></div>
                                        <input type='text' placeholder='نام و نام خانوادگی' name='name'>
                                        <span class='focus_bg'></span>
                                    </li>
                                    <li class='item'>
                                        <div class='icon'><i class='i-mail-2'></i></div>
                                        <input type='text' placeholder='ایمیل' name='email'>
                                        <span class='focus_bg'></span>
                                    </li>
                                    <li class='item textarea'>
                                        <div class='ico");
                WriteLiteral(@"n'><i class='i-chat'></i></div>
                                        <textarea placeholder='متن پیام شما...' name='message'></textarea>
                                        <span class='focus_bg'></span>
                                    </li>
                                    <li class='item submit'>
                                        <button>ارسال پیام</button>
                                    </li>
                                </ul>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div><!--close .form_style2-->
                    </div><!--close .right_part-->
                </div><!--close .inner-->
            </div><!--close .container-->
        </div><!--close .top_part-->
        <div class='bottom_part'>
            <div class='container'>
                <div class='inner'>
                    <div class='icon'><div class='hand_range'><div class='hand'></div></div></div>
                    <div class='track_order'>
                        <div class='text'>
                            برای پیگیری شفارش خود به صفحه زیر مراجعه کنید.
                        </div>
                        <a href='user/order'");
            BeginWriteAttribute("title", " title=\'", 3875, "\'", 3883, 0);
            EndWriteAttribute();
            WriteLiteral(@" class='btn_style2'><span>پیگیری سفارش</span></a>
                    </div>
                </div><!--close .inner-->
            </div><!--close .container-->
        </div><!--close .bottom_part-->
    </div><!--close .contact_part-->
    <!--<div class='contact_part2'>
        <div id='map'></div>
    </div>-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591