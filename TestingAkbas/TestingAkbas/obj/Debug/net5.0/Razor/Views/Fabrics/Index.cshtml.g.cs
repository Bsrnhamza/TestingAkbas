#pragma checksum "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff42151935b35e072ea64f23e3b515280dc8b34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fabrics_Index), @"mvc.1.0.view", @"/Views/Fabrics/Index.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\_ViewImports.cshtml"
using TestingAkbas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\_ViewImports.cshtml"
using TestingAkbas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff42151935b35e072ea64f23e3b515280dc8b34", @"/Views/Fabrics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859597759fcd14fa84bc3293287c898b72ace20b", @"/Views/_ViewImports.cshtml")]
    public class Views_Fabrics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAkbas.Models.Fabric>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this item?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff42151935b35e072ea64f23e3b515280dc8b345665", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 16 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QualityClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FabricCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 18 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qualities));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 19 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QualityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 20 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QualityGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 21 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QualityComposition));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PatternType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RawFabricPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 26 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DomesticPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 27 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExportPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 1263, "\"", 1314, 1);
#nullable restore
#line 35 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 1271, GetQualityClassCssClass(item.QualityClass), 1271, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 36 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QualityClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 1430, "\"", 1475, 1);
#nullable restore
#line 38 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 1438, GetQualitiesCssClass(item.Qualities), 1438, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 39 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FabricCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 1589, "\"", 1634, 1);
#nullable restore
#line 41 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 1597, GetQualitiesCssClass(item.Qualities), 1597, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 42 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Qualities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 1747, "\"", 1792, 1);
#nullable restore
#line 44 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 1755, GetQualitiesCssClass(item.Qualities), 1755, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 45 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QualityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1952, 1);
#nullable restore
#line 47 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 1915, GetQualitiesCssClass(item.Qualities), 1915, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 48 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QualityGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2068, "\"", 2113, 1);
#nullable restore
#line 50 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2076, GetQualitiesCssClass(item.Qualities), 2076, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 51 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QualityComposition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2235, "\"", 2280, 1);
#nullable restore
#line 53 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2243, GetQualitiesCssClass(item.Qualities), 2243, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 54 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PatternType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2395, "\"", 2440, 1);
#nullable restore
#line 56 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2403, GetQualitiesCssClass(item.Qualities), 2403, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 57 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2549, "\"", 2594, 1);
#nullable restore
#line 59 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2557, GetQualitiesCssClass(item.Qualities), 2557, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 60 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2704, "\"", 2749, 1);
#nullable restore
#line 62 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2712, GetQualitiesCssClass(item.Qualities), 2712, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 63 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RawFabricPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 2867, "\"", 2912, 1);
#nullable restore
#line 65 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 2875, GetQualitiesCssClass(item.Qualities), 2875, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 66 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DomesticPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("class", " class=\"", 3029, "\"", 3074, 1);
#nullable restore
#line 68 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
WriteAttributeValue("", 3037, GetQualitiesCssClass(item.Qualities), 3037, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 69 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExportPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group\" role=\"group\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff42151935b35e072ea64f23e3b515280dc8b3419987", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-warning\">Edit</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff42151935b35e072ea64f23e3b515280dc8b3422570", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-info\">Details</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff42151935b35e072ea64f23e3b515280dc8b3425156", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        /* QualityClass renkleri */
        .quality-class-viscose {
            background-color: rgba(255, 165, 0, 0.5); /* orange */
        }

        .quality-class-rayon {
            background-color: rgba(0, 128, 0, 0.5); /* green */
        }

        .quality-class-cotton {
            background-color: rgba(128, 0, 128, 0.5); /* purple */
        }

        .quality-class-nylon {
            background-color: rgba(255, 255, 0, 0.5); /* yellow */
        }

        .quality-class-polyester {
            background-color: rgba(255, 0, 0, 0.5); /* red */
        }

        .quality-class-tencel {
            background-color: rgba(0, 0, 255, 0.5); /* blue */
        }

        .quality-class-linen {
            background-color: rgba(173, 216, 230, 0.5); /* lightblue */
        }

        .quality-class-jacquard {
            background-color: rgba(128, 128, 128, 0.5); /* gray */
        }

        .quality-class-mix {
            background-color: rgba");
                WriteLiteral(@"(211, 211, 211, 0.5); /* lightgray */
        }

        /* Qualities renkleri */
        .qualities-m {
            background-color: rgba(144, 238, 144, 0.25); /* lightgreen */
        }

        .qualities-a {
            background-color: rgba(173, 216, 230, 0.25); /* lightblue */
        }

        .qualities-n {
            background-color: rgba(255, 255, 224, 0.25); /* lightyellow */
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "C:\Users\hp\source\repos\TestingAkbas\TestingAkbas\TestingAkbas\Views\Fabrics\Index.cshtml"
            
    public string GetQualityClassCssClass(string qualityClass)
    {
        switch (qualityClass?.ToLower())
        {
            case "viscose":
                return "quality-class-viscose";
            case "rayon":
            case "rynsignart":
                return "quality-class-rayon";
            case "cotton":
                return "quality-class-cotton";
            case "nylon":
                return "quality-class-nylon";
            case "polyester":
            case "pesdouble":
                return "quality-class-polyester";
            case "tencel":
            case "modal":
                return "quality-class-tencel";
            case "linen":
                return "quality-class-linen";
            case "jacquard":
                return "quality-class-jacquard";
            case "mix":
            case "yarndyed":
                return "quality-class-mix";
            default:
                return "";
        }
    }

    public string GetQualitiesCssClass(string qualities)
    {
        switch (qualities?.ToLower())
        {
            case "m":
                return "qualities-m";
            case "a":
                return "qualities-a";
            case "n":
                return "qualities-n";
            default:
                return "";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAkbas.Models.Fabric>> Html { get; private set; }
    }
}
#pragma warning restore 1591
