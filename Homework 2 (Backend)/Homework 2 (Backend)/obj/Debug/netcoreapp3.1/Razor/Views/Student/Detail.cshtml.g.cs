#pragma checksum "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62a22544f96a01b93dc535bb3f0e738920ccf2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\_ViewImports.cshtml"
using Homework_2__Backend_.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\_ViewImports.cshtml"
using Homework_2__Backend_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62a22544f96a01b93dc535bb3f0e738920ccf2c", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1feb7690ed7b34147a26f56320bc006bdba20f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Details</h1>\r\n<h2>FullName: ");
#nullable restore
#line 4 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\Student\Detail.cshtml"
         Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Point:  <span");
            BeginWriteAttribute("style", " style=\"", 89, "\"", 134, 2);
            WriteAttributeValue("", 97, "color:", 97, 6, true);
#nullable restore
#line 5 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\Student\Detail.cshtml"
WriteAttributeValue("", 103, Model.Point<65?"red":"green", 103, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 5 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\Student\Detail.cshtml"
                                                           Write(Model.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n<h2>Id: ");
#nullable restore
#line 6 "C:\Users\Maqsud\Desktop\Homeworks\Homework 2 (Backend)\Homework 2 (Backend)\Views\Student\Detail.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
