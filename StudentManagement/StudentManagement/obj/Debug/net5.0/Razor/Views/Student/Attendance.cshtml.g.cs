#pragma checksum "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad44ce36bd8b147a7f44ce0ace4e2fb9a434ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Attendance), @"mvc.1.0.view", @"/Views/Student/Attendance.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad44ce36bd8b147a7f44ce0ace4e2fb9a434ba6", @"/Views/Student/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Attendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Schedule>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("attendance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckAttendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">

<nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""home"">Schedule</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navba");
            WriteLiteral(@"r-collapse justify-content-end"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav m-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Manager Admin</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Hello Ngoc Hoan</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Login</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<h3>Class Detail</h3>
<div class=""container-fluid"">
    <button form=""attendance"" onclick=""this.form.submit()"" type=""button"" class=""btn btn-success"">Submit</button>
    <table class=""table"">
        <thead>
            <tr>
                <td>
                    INDEX
                </td>
                <td>
                    Full Name
                </td>
                <td>
                    Code
                </td>
                <td>
       ");
            WriteLiteral("             Present\r\n                </td>\r\n                <td>\r\n                    Image\r\n                </td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad44ce36bd8b147a7f44ce0ace4e2fb9a434ba67113", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
                 foreach (var item in ViewBag.student)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                            ");
#nullable restore
#line 66 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                            ");
#nullable restore
#line 69 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
                       Write(item.StudentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                            ");
#nullable restore
#line 72 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
                       Write(item.StudentCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <input");
                BeginWriteAttribute("value", " value=\"", 2927, "\"", 2950, 1);
#nullable restore
#line 75 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
WriteAttributeValue("", 2935, item.StudentId, 2935, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"attendance\"> \r\n                        <input type=\"hidden\" name=\"scheduleId\"");
                BeginWriteAttribute("value", " value=\"", 3051, "\"", 3078, 1);
#nullable restore
#line 76 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
WriteAttributeValue("", 3059, ViewBag.scheduleId, 3059, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"classId\"");
                BeginWriteAttribute("value", " value=\"", 3141, "\"", 3165, 1);
#nullable restore
#line 77 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
WriteAttributeValue("", 3149, ViewBag.classId, 3149, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 3250, "\"", 3281, 2);
                WriteAttributeValue("", 3256, "/lib/img/", 3256, 9, true);
#nullable restore
#line 80 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
WriteAttributeValue("", 3265, item.StudentImg, 3265, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"90px\" height=\"90px\">\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 83 "D:\S5\gihubClone\project_prn211\StudentManagement\StudentManagement\Views\Student\Attendance.cshtml"
                    count++;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Models.Schedule> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
