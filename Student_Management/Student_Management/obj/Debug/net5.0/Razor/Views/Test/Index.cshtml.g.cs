#pragma checksum "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "048eb3adf8b774dbd6ee033e806195d22f296fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
#line 1 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\_ViewImports.cshtml"
using Student_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml"
using Student_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048eb3adf8b774dbd6ee033e806195d22f296fc9", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1a599df537dd12480acea2bc3bf50095dfa2ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml"
 foreach (Slot s in @ViewBag.SlotList){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n");
#nullable restore
#line 10 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml"
Write(s.SlotId);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n");
#nullable restore
#line 12 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml"
Write(s.SlotTime);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FPT\Semester_5\PRN211\Project\project_prn211\Student_Management\Student_Management\Views\Test\Index.cshtml"
               
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
