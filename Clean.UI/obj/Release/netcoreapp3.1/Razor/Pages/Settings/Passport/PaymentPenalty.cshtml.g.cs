#pragma checksum "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5f663bd583c6121ae2296ccadaca378c474a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clean.UI.Pages.Settings.Passport.Pages_Settings_Passport_PaymentPenalty), @"mvc.1.0.razor-page", @"/Pages/Settings/Passport/PaymentPenalty.cshtml")]
namespace Clean.UI.Pages.Settings.Passport
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
#line 1 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\_ViewImports.cshtml"
using Clean.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5f663bd583c6121ae2296ccadaca378c474a59", @"/Pages/Settings/Passport/PaymentPenalty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e588d119d3749322bd1c215836697b37532af0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings_Passport_PaymentPenalty : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("uxdofficeid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "uxdOfficeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dv_Settings_Passport_PaymentPenalty"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form main-form page-component"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("prefix", new global::Microsoft.AspNetCore.Html.HtmlString("uxd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
  
    ViewData["Title"] = "PaymentPenalty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"panel panel-flat\" >\r\n    <div class=\"panel-heading\">\r\n        <h1 class=\"panel-title\">");
#nullable restore
#line 12 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                           Write(_localizer["تنظیمات جریمه‌های نقدی"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5f663bd583c6121ae2296ccadaca378c474a597082", async() => {
                WriteLiteral("\r\n            <fieldset class=\"content-group\">\r\n                <legend class=\"text-bold\">");
#nullable restore
#line 17 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                     Write(_localizer["ثبت و ویرایش جریمه‌های نقدی"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</legend>
                <div class=""col-md-12 "">
                    <div class=""row"">
                        <div class=""col-md-2 col-sm-4 col-xs-12 "">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 23 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                               Write(_localizer["اداره"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <span class=\"text-danger\">&nbsp;*</span>\r\n                                </label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5f663bd583c6121ae2296ccadaca378c474a598507", async() => {
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5f663bd583c6121ae2296ccadaca378c474a598811", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 26 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListOfOffices;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-4 col-xs-12 "">
                            <div class=""form-group"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 34 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                               Write(_localizer["نام جریمه"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <span class=""text-danger"">&nbsp;*</span>
                                </label>
                                <input type=""text"" id=""uxdtitle"" name=""uxdTitle"" class=""form-control"" required />
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-4 col-xs-12 "">
                            <div class=""form-group"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 43 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                               Write(_localizer["مقدار/قیمت"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <span class=""text-danger"">&nbsp;*</span>
                                </label>
                                <input type=""number"" id=""uxdamount"" name=""uxdAmount"" class=""form-control"" required />
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-12 col-xs-12 "">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">");
#nullable restore
#line 51 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                                    Write(_localizer["فعال | ‌غیر فعال"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <input type=""checkbox"" class=""checkbox"" id=""uxdisactive"" name=""uxdIsActive"" />
                            </div>
                        </div>
                    </div>
                </div>
            </fieldset>
            <hr />
            <div class=""row div-form-control main-form-details"">
                <div class=""col-md-12"">
                    <div class=""form-group actions"">
                        <button type=""button"" class=""btn btn-primary"" action=""save""><i class=""icon-floppy-disk position-left""></i>ثبت معلومات</button>
                        <button type=""button"" class=""btn btn-primary"" action=""search""><i class=""icon-search4 position-left""></i>جستجو </button>
                        <button type=""button"" class=""btn btn-primary"" action=""new""><i class=""icon-new-tab position-left""></i>صفحه جدید </button>
                    </div>
                </div>
            </div>
            <div class=""form-grid main-form-details""");
                BeginWriteAttribute("style", " style=\"", 3818, "\"", 3826, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <table  bindonclick=\"true\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th colname=\"office\">");
#nullable restore
#line 72 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                            Write(_localizer["اداره"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th colname=\"title\">");
#nullable restore
#line 73 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                           Write(_localizer["نام"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th colname=\"status\">");
#nullable restore
#line 74 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                            Write(_localizer["نوعیت"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th colname=\"amount\">");
#nullable restore
#line 75 "C:\Users\ZIA\source\repos\Passport\Clean.UI\Pages\Settings\Passport\PaymentPenalty.cshtml"
                                            Write(_localizer["مقدار/قیمت"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody></tbody>\r\n                </table>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer _localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clean.UI.Pages.Settings.Passport.PaymentPenaltyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Settings.Passport.PaymentPenaltyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Settings.Passport.PaymentPenaltyModel>)PageContext?.ViewData;
        public Clean.UI.Pages.Settings.Passport.PaymentPenaltyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
