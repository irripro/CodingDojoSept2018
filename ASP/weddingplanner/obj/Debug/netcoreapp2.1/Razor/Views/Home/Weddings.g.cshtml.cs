#pragma checksum "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15cba353f7ff4f4af94ce8ed6fabd90f225913a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weddings), @"mvc.1.0.view", @"/Views/Home/Weddings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Weddings.cshtml", typeof(AspNetCore.Views_Home_Weddings))]
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
#line 2 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\_ViewImports.cshtml"
using weddingplanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15cba353f7ff4f4af94ce8ed6fabd90f225913a", @"/Views/Home/Weddings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d24a8a9203ddc66170c99071ee65ab4e504c6bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Weddings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 484, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2067a69b4b6d4dc1a9a3404b7b74471e", async() => {
                BeginContext(43, 392, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm""
        crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(435, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adeb52e5f49349f08ecb2d89bd29e450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(483, 31, true);
                WriteLiteral("\r\n    <title>Document</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(525, 1490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc10bd6f03f147f5abe687073a2c68e8", async() => {
                BeginContext(531, 228, true);
                WriteLiteral("\r\n    <div class=\"jumbotron\">\r\n        <h1 class=\"text-left\">Welcome to the Wedding Planner</h1>\r\n        <a class=\"text-right\" href=\"/logout\">Logout</a>\r\n    </div>\r\n    <div class=\"container\">\r\n        <h3 class=\"text-center\">");
                EndContext();
                BeginContext(760, 25, false);
#line 20 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                           Write(ViewBag.AllWeddings.Count);

#line default
#line hidden
                EndContext();
                BeginContext(785, 155, true);
                WriteLiteral(" Total Weddings</h3>\r\n        <table>\r\n            <th>Wedding</th>\r\n            <th>Date</th>\r\n            <th>Guests</th>\r\n            <th>Actions</th>\r\n");
                EndContext();
#line 26 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
             foreach(var x in ViewBag.AllWeddings){

#line default
#line hidden
                BeginContext(993, 40, true);
                WriteLiteral("            <tr>\r\n                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1033, "\"", 1058, 2);
                WriteAttributeValue("", 1040, "/show/", 1040, 6, true);
#line 28 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
WriteAttributeValue("", 1046, x.WeddingId, 1046, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1059, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1061, 7, false);
#line 28 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                                            Write(x.bride);

#line default
#line hidden
                EndContext();
                BeginContext(1068, 5, true);
                WriteLiteral(" and ");
                EndContext();
                BeginContext(1074, 7, false);
#line 28 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                                                         Write(x.groom);

#line default
#line hidden
                EndContext();
                BeginContext(1081, 31, true);
                WriteLiteral("</a></td>\r\n                <td>");
                EndContext();
                BeginContext(1113, 6, false);
#line 29 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
               Write(x.date);

#line default
#line hidden
                EndContext();
                BeginContext(1119, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1147, 7, false);
#line 30 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
               Write(x.total);

#line default
#line hidden
                EndContext();
                BeginContext(1154, 49, true);
                WriteLiteral("</td>\r\n                <!-- <td><a href=\"/unrsvp/");
                EndContext();
                BeginContext(1204, 11, false);
#line 31 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                                     Write(x.WeddingId);

#line default
#line hidden
                EndContext();
                BeginContext(1215, 24, true);
                WriteLiteral("\">un-rsvp</a></td> -->\r\n");
                EndContext();
#line 32 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                  if(x.UserId == ViewBag.UserId){

#line default
#line hidden
                BeginContext(1290, 22, true);
                WriteLiteral("                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1312, "\"", 1339, 2);
                WriteAttributeValue("", 1319, "/delete/", 1319, 8, true);
#line 33 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
WriteAttributeValue("", 1327, x.WeddingId, 1327, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1340, 18, true);
                WriteLiteral(">delete</a></td>\r\n");
                EndContext();
#line 34 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                }

                else{
                int Count = 0;
                

#line default
#line hidden
#line 38 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                 foreach(var guest in @x.guests) {
                

#line default
#line hidden
#line 39 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                 if(@guest.UserId == @ViewBag.UserId) {
                Count = 1;
                }

#line default
#line hidden
#line 41 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                 
                }

#line default
#line hidden
#line 42 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                 
                if(Count == 1) {

#line default
#line hidden
                BeginContext(1643, 22, true);
                WriteLiteral("                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1665, "\"", 1692, 2);
                WriteAttributeValue("", 1672, "/unrsvp/", 1672, 8, true);
#line 44 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
WriteAttributeValue("", 1680, x.WeddingId, 1680, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1693, 19, true);
                WriteLiteral(">un-rsvp</a></td>\r\n");
                EndContext();
#line 45 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                }
                else {

#line default
#line hidden
                BeginContext(1755, 22, true);
                WriteLiteral("                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1777, "\"", 1802, 2);
                WriteAttributeValue("", 1784, "/rsvp/", 1784, 6, true);
#line 47 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
WriteAttributeValue("", 1790, x.WeddingId, 1790, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1803, 16, true);
                WriteLiteral(">rsvp</a></td>\r\n");
                EndContext();
#line 48 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
                }
                }
                

#line default
#line hidden
                BeginContext(1876, 19, true);
                WriteLiteral("            </tr>\r\n");
                EndContext();
#line 52 "C:\Users\zach\Desktop\ASP\weddingplanner\Views\Home\Weddings.cshtml"
            }

#line default
#line hidden
                BeginContext(1910, 98, true);
                WriteLiteral("        </table><br>\r\n        <button><a href=\"/newwedding\">New Wedding</a></button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2015, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
