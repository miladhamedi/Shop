#pragma checksum "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be877b2d60c44b5cae3ad522e8038bb96662db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ChangPhoneNumber), @"mvc.1.0.view", @"/Views/Profile/ChangPhoneNumber.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be877b2d60c44b5cae3ad522e8038bb96662db5", @"/Views/Profile/ChangPhoneNumber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2feb48d13041387f4c41337defd6c7404f988aea", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_ChangPhoneNumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneNumberViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeaderProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("شماره همراه را وارد کنید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm_register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmPhone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-returnurl", "Profile/ChangPhoneNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1be877b2d60c44b5cae3ad522e8038bb96662db58430", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1be877b2d60c44b5cae3ad522e8038bb96662db59669", async() => {
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
            WriteLiteral("\r\n            <div class=\'panel_content\'>\r\n");
#nullable restore
#line 11 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
                  
                    if (ViewBag.Message != null)
                    {
                        var message = ViewBag.Message.ToString();

                        if (ViewBag.Status == true)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alarm_style2\">\r\n                                <div class=\"success_alarm box\">\r\n                                    <div class=\"alarm_icon\"><img src=\"/assets/front/_images/icon/checked.png\"");
            BeginWriteAttribute("alt", " alt=\"", 727, "\"", 733, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                    <div class=\"alarm_text\">");
#nullable restore
#line 22 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
                                                       Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"close_icon\"><i class=\"i-cancel\"></i></div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 26 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"

                        }
                        if (ViewBag.Status == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alarm_style2\">\r\n                                <div class=\"success_alarm box\">\r\n                                    <div class=\"alarm_icon\"><img src=\"/assets/front/_images/icon/checked.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1327, "\"", 1333, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                    <div class=\"alarm_text\">");
#nullable restore
#line 33 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
                                                       Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"close_icon\"><i class=\"i-cancel\"></i></div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 37 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"

                        }

                    }




                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class='form_style2'>
                <div class='register_part1'>

                    <div class='container'>
                        <div class='inner clearfix'>
                            <div class='signin_part center-block '>
                                <div class='part_inner'>
                                    <div class='title_style7'>
                                        <div class='title'> ویرایش شماره همراه </div>
                                    </div>
                                    <div class='form_style2'>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be877b2d60c44b5cae3ad522e8038bb96662db514242", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be877b2d60c44b5cae3ad522e8038bb96662db514545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 59 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            <input type=""hidden"" name=""_token"" value=""dsIvqII2PJDqUl2f2CzMupXHJ2TfV59ozigxe4jM"">

                                            <ul class='step none_list_style clearfix'>

                                                <li class='item'>
                                                    <div class='icon'><i class='i-mobile'></i></div>
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1be877b2d60c44b5cae3ad522e8038bb96662db516570", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 66 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
                                                                            WriteLiteral(ViewBag.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    <span class=\'focus_bg\'></span>\r\n                                                    <span class=\'important\'><i class=\'i-star\'></i></span>\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be877b2d60c44b5cae3ad522e8038bb96662db519123", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 69 "F:\Shop\EndPoint\Shop.EndPoint.Web.Ui\Views\Profile\ChangPhoneNumber.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </li>

                                                <li class='item submit'>
                                                    <button type=""submit"" class=""submit"">ارسال</button>
                                                </li>

                                            </ul>

                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = (string)__tagHelperAttribute_6.Value;
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
            WriteLiteral(@"
                                    </div>
                                </div><!-- close .part_inner -->
                            </div><!-- close .signin_part -->
                        </div><!-- close .inner -->
                    </div><!-- close .continer -->
                </div><!-- close .register_part1 -->

            </div><!--close .form_style2-->

            </div><!--clsoe .panel_content-->
        </div><!--close .inner-->
    </div><!--close .container-->
</div><!--close .panel_style1-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneNumberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591