#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4fffe0f304fcfb7f45af643d26771c73dd92ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_PostInformation), @"mvc.1.0.view", @"/Views/Cart/PostInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fffe0f304fcfb7f45af643d26771c73dd92ca0", @"/Views/Cart/PostInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2feb48d13041387f4c41337defd6c7404f988aea", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_PostInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_style1 add_cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
  

    ViewBag.Breadcromb = " اطلاعات آدرس پستی";
    ViewBag.Title = " اطلاعات آدرس پستی";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4fffe0f304fcfb7f45af643d26771c73dd92ca08291", async() => {
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

<div class='cart_part1'>
    <div class='container'>
        <div class='inner'>
            <div class='top_part'>
                <ul class='step clearfix none_list_style'>
                    <li class='item  checked  '>
                        <a");
            BeginWriteAttribute("href", " href=\'", 419, "\'", 426, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 427, "\'", 435, 0);
            EndWriteAttribute();
            WriteLiteral(@" class='link'>
                            <div class='number'>
                                <span>1</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""-90 -1 792 737"" style=""enable-background:new -90 -1 792 737;"" xml:space=""preserve"">
                                    <path id=""dec-post-arrow"" d=""M702,736c-237.6-26.4-369.6-158.4-396-396C279.6,577.6,147.6,709.6-90,736"" />
                                    <path id=""dec-post-arrow_1_"" d=""M-90-1c237.6,26.4,369.6,158.4,396,396C332.4,157.4,464.4,25.4,702-1"" />
                                   </svg>
                                </div>
                            </div><!--close .number-->
                            <div class='content'>
                                <span>سبد خرید</span>
                            ");
            WriteLiteral(@"    <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""0 199 792 396"" style=""enable-background:new 0 199 792 396;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow_1_""
                                          d=""M0,198c237.6,26.4,369.6,158.4,396,396c26.4-237.6,158.4-369.6,396-396"" />
                                            </svg>
                                </div>
                            </div><!--close .content-->
                        </a>
                    </li><!--close .item-->
                    <li class='item active'>
                        <a");
            BeginWriteAttribute("href", " href=\'", 2350, "\'", 2357, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 2358, "\'", 2366, 0);
            EndWriteAttribute();
            WriteLiteral(@" class='link'>
                            <div class='number'>
                                <span>2</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""-90 -1 792 737"" style=""enable-background:new -90 -1 792 737;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow""
                                          d=""M702,736c-237.6-26.4-369.6-158.4-396-396C279.6,577.6,147.6,709.6-90,736"" />
                                    <path id=""dec-post-arrow_1_""
                                          d=""M-90-1c237.6,26.4,369.6,158.4,396,396C332.4,157.4,464.4,25.4,702-1"" />
                                            </svg>
                                </div>
           ");
            WriteLiteral(@"                 </div>
                            <div class='content'>
                                <span>اطلاعات پستی گیرنده</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""0 199 792 396"" style=""enable-background:new 0 199 792 396;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow_1_""
                                          d=""M0,198c237.6,26.4,369.6,158.4,396,396c26.4-237.6,158.4-369.6,396-396"" />
                                            </svg>
                                </div>
                            </div>
                        </a>
                    </li><!--close .item-->
                    <li class='item  '>
                ");
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\'", 4425, "\'", 4432, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 4433, "\'", 4441, 0);
            EndWriteAttribute();
            WriteLiteral(@" class='link'>
                            <div class='number'>
                                <span>3</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""-90 -1 792 737"" style=""enable-background:new -90 -1 792 737;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow""
                                          d=""M702,736c-237.6-26.4-369.6-158.4-396-396C279.6,577.6,147.6,709.6-90,736"" />
                                    <path id=""dec-post-arrow_1_""
                                          d=""M-90-1c237.6,26.4,369.6,158.4,396,396C332.4,157.4,464.4,25.4,702-1"" />
                                            </svg>
                                </div>
           ");
            WriteLiteral(@"                 </div>
                            <div class='content'>
                                <span>اطلاعات ارسال سفارش</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""0 199 792 396"" style=""enable-background:new 0 199 792 396;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow_1_""
                                          d=""M0,198c237.6,26.4,369.6,158.4,396,396c26.4-237.6,158.4-369.6,396-396"" />
                                            </svg>
                                </div>
                            </div>
                        </a>
                    </li><!--close .item-->
                    <li class='item  '>
                ");
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\'", 6500, "\'", 6507, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\'", 6508, "\'", 6516, 0);
            EndWriteAttribute();
            WriteLiteral(@" class='link'>
                            <div class='number'>
                                <span>4</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""-90 -1 792 737"" style=""enable-background:new -90 -1 792 737;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow""
                                          d=""M702,736c-237.6-26.4-369.6-158.4-396-396C279.6,577.6,147.6,709.6-90,736"" />
                                    <path id=""dec-post-arrow_1_""
                                          d=""M-90-1c237.6,26.4,369.6,158.4,396,396C332.4,157.4,464.4,25.4,702-1"" />
                                       </svg>
                                </div>
                ");
            WriteLiteral(@"            </div>
                            <div class='content'>
                                <span>بازبینی سفارش</span>
                                <div class='svg_arrow'>
                                    <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         viewBox=""0 199 792 396"" style=""enable-background:new 0 199 792 396;""
                                         xml:space=""preserve"">
                                    <path id=""dec-post-arrow_1_""
                                          d=""M0,198c237.6,26.4,369.6,158.4,396,396c26.4-237.6,158.4-369.6,396-396"" />
                                            </svg>
                                </div>
                            </div>
                        </a>
                    </li><!--close .item-->

                </ul><!--close .step-->
            </div><!--clo");
            WriteLiteral("se .top_part-->\r\n            <div class=\'bottom_part\'>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4fffe0f304fcfb7f45af643d26771c73dd92ca019237", async() => {
                WriteLiteral(@"
                    <div class='addres_select'>
                        <ul class='step none_list_style'>
                            <li class='item"">
                                <label for='address9'>
                                    <div class='table1'>
                                        <table>
                                            <tr>
                                                <td rowspan='2' width='70'
                                                    style='border-right:solid 1px #DDD; padding:0;'>
                                                    <label class='check_radio_style1'>
                                                        <input type='radio' name='post' value=""9"" id='address9'
                                                               checked>
                                                        <span class='icon'></span>
                                                    </label>
                                                </td>
 ");
                WriteLiteral("                                               <td colspan=\'2\' width=\'220\'>\r\n                                                    اطلاعات تماس منزل به نام\r\n                                                    <span>");
#nullable restore
#line 154 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                     Write(Model.NameFamily);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                    <span>");
#nullable restore
#line 155 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                     Write(Model.NormalizedEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td colspan=\'2\' width=\'220\'>");
#nullable restore
#line 157 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                                       Write(Model.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 157 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                                                     Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            </tr>\r\n                                            <tr>\r\n                                                <td>استان ");
#nullable restore
#line 160 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                     Write(Model.Province);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>شهر ");
#nullable restore
#line 161 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                   Write(Model.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>شماره همراه ");
#nullable restore
#line 162 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>کدپستی ");
#nullable restore
#line 163 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Cart\PostInformation.cshtml"
                                                      Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                            </tr>
                                        </table>
                                    </div><!-- close .table1 -->
                                </label>
                            </li><!-- close .item -->
                        </ul><!-- close .step -->
                    </div><!-- close .addres_select -->
                    <div class='form_style2'>
                    </div><!--close .form_style2-->
                    <div class='cart_btn'>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4fffe0f304fcfb7f45af643d26771c73dd92ca024111", async() => {
                    WriteLiteral("\r\n                            <i class=\'i-marker\'></i>\r\n                            <span> اصلاح آدرس </span>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <button style=""border: none;vertical-align: top;cursor: pointer;"" type=""submit""
                                class='btn_style1 add_cart'>
                            <i class='i-left-open'></i><span>مرحله بعدی</span>
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div><!--close .bottom_part-->\r\n        </div><!--close .inner-->\r\n    </div><!--close .container-->\r\n</div><!--close .cart_part1-->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591