#pragma checksum "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c809482312f1be4644d3db3e8e1f92df6e6a5f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\_ViewImports.cshtml"
using Assignment4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\_ViewImports.cshtml"
using Assignment4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c809482312f1be4644d3db3e8e1f92df6e6a5f0a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0176612570e29c54708517295539c15233f55fac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment4.Models.EF_Models.UniversityData>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
  string url = "https://" + Model.results[0].schoolUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c809482312f1be4644d3db3e8e1f92df6e6a5f0a4004", async() => {
                WriteLiteral(@"
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        *{
            box-sizing: border-box;
        } 

        /* Full-width input fields */
        p {
            width: 100%;
            padding: 15px;
            margin: 5px 0 22px 0;
            display: inline-block;
            border: none;
            background: #f1f1f1;
            color:black;
        }


        hr {
            border: 1px solid #f1f1f1;
            margin-bottom: 25px;
        }

        /* Add padding to container elements */
        .container {
            padding: 16px;
            max-width: 70%;
        }

        /* Clear floats */
        .clearfix::after {
            content: """";
            clear: both;
            display: table;
        }
    </style>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c809482312f1be4644d3db3e8e1f92df6e6a5f0a5773", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <h1>");
#nullable restore
#line 57 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
       Write(Model.results[0].schoolName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n        <a");
                BeginWriteAttribute("href", " href=", 1073, "", 1083, 1);
#nullable restore
#line 58 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
WriteAttributeValue("", 1079, url, 1079, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h6 ");
#nullable restore
#line 58 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
                    Write(Model.results[0].schoolUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></a>\n        <hr />\n\n        <label><b>City:</b></label>\n        <p class=\"card-text\">");
#nullable restore
#line 62 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
                        Write(Model.results[0].schoolCity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <br />\n\n        <label for=\"Contact no\"><b>Accreditation:</b></label>\n");
#nullable restore
#line 66 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
         if (@Model.results[0].accCode != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p class=\"card-text\">");
#nullable restore
#line 67 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
                         Write(Model.results[0].accCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> ");
#nullable restore
#line 67 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
                                                            }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Data Not Available</p>\n");
#nullable restore
#line 71 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n\n        <label><b>Tuition Fee:</b></label>\n");
#nullable restore
#line 75 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
         if (@Model.results[0].tuitionOutState != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>");
#nullable restore
#line 77 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
          Write(Model.results[0].tuitionOutState);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 78 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>Data Not Available</p>\n");
#nullable restore
#line 82 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n\n        <label><b>Student Size:</b></label>\n");
#nullable restore
#line 86 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
         if (Model.results[0].studentSize != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"card-text\">");
#nullable restore
#line 88 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
                            Write(Model.results[0].studentSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 89 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"card-text\">Data Not Available</p>\n");
#nullable restore
#line 93 "C:\Users\prith\Downloads\Assignment4-master (2)\Assignment4-master\Assignment4-master\Assignment4\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("        <br />\n    </div>\n   \n\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment4.Models.EF_Models.UniversityData> Html { get; private set; }
    }
}
#pragma warning restore 1591
