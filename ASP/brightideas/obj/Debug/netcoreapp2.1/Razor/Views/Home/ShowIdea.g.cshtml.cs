#pragma checksum "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e07b352f6f2585552c01413997cbd06d8c8269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowIdea), @"mvc.1.0.view", @"/Views/Home/ShowIdea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowIdea.cshtml", typeof(AspNetCore.Views_Home_ShowIdea))]
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
#line 2 "C:\Users\zach\Desktop\ASP\brightideas\Views\_ViewImports.cshtml"
using brightideas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e07b352f6f2585552c01413997cbd06d8c8269", @"/Views/Home/ShowIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f742fc0313b1f32a6073fd98feaec84ab7b0694f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 475, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b26af2bf9498eb0573ae16c5251c7", async() => {
                BeginContext(41, 169, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    ");
                EndContext();
                BeginContext(210, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe64438cc7194c96bb86d4131be880dd", async() => {
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
                BeginContext(257, 246, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\"\r\n    crossorigin=\"anonymous\">\r\n    <title>Idea</title>\r\n");
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
            BeginContext(510, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(512, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d6fdb4d9aff473e8813f3c9d1ff69df", async() => {
                BeginContext(518, 171, true);
                WriteLiteral("\r\n    <div class=\"header\"><p class=\"rightside text-right\"><a href=\"/Ideas\">Bright Ideas</a> <a href=\"/logout\">Logout</a></p></div>\r\n    <div class=\"container\"> \r\n    <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 689, "\"", 722, 2);
                WriteAttributeValue("", 696, "/user/", 696, 6, true);
#line 15 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
WriteAttributeValue("", 702, ViewBag.User.UserId, 702, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(723, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(725, 22, false);
#line 15 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
                                       Write(ViewBag.User.firstname);

#line default
#line hidden
                EndContext();
                BeginContext(747, 29, true);
                WriteLiteral("</a> says: <span class=\"box\">");
                EndContext();
                BeginContext(777, 20, false);
#line 15 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
                                                                                           Write(ViewBag.Idea.content);

#line default
#line hidden
                EndContext();
                BeginContext(797, 130, true);
                WriteLiteral("</span></p>\r\n    <p><strong>People who liked this post:</strong></p>\r\n    <table>\r\n        <th>alias</th>\r\n        <th>Name</th>\r\n");
                EndContext();
#line 20 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
         foreach (var like in @ViewBag.Likes){

#line default
#line hidden
                BeginContext(975, 32, true);
                WriteLiteral("        <tr>\r\n            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1007, "\"", 1037, 2);
                WriteAttributeValue("", 1014, "/user/", 1014, 6, true);
#line 22 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
WriteAttributeValue("", 1020, like.user.UserId, 1020, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1038, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1040, 15, false);
#line 22 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
                                             Write(like.user.alias);

#line default
#line hidden
                EndContext();
                BeginContext(1055, 27, true);
                WriteLiteral("</a></td>\r\n            <td>");
                EndContext();
                BeginContext(1083, 19, false);
#line 23 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
           Write(like.user.firstname);

#line default
#line hidden
                EndContext();
                BeginContext(1102, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1104, 18, false);
#line 23 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
                                Write(like.user.lastname);

#line default
#line hidden
                EndContext();
                BeginContext(1122, 22, true);
                WriteLiteral("</td>\r\n        </tr>\r\n");
                EndContext();
#line 25 "C:\Users\zach\Desktop\ASP\brightideas\Views\Home\ShowIdea.cshtml"
}

#line default
#line hidden
                BeginContext(1147, 22, true);
                WriteLiteral("    </table>\r\n</div>\r\n");
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
            BeginContext(1176, 9, true);
            WriteLiteral("\r\n</html>");
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