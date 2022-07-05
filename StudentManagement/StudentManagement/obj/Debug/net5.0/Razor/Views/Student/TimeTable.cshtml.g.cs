#pragma checksum "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e750f97518183957a3b246e2b4fdd3d1f975c4bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_TimeTable), @"mvc.1.0.view", @"/Views/Student/TimeTable.cshtml")]
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
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e750f97518183957a3b246e2b4fdd3d1f975c4bb", @"/Views/Student/TimeTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_TimeTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Schedule>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
  
    Dictionary<int, Dictionary<string, Schedule>> map = ViewBag.TimeTable;

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

        <div class=""collapse");
            WriteLiteral(@" navbar-collapse justify-content-end"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav m-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Manager Admin</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Hello Huu Quyet</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Login</a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<h1>Activities for ...(HE152222)</h1>
<h3>Select a term, course ...</h3>
<div class=""container-fluid"">
    <div class=""timetable-img text-center"">
        <img src=""img/content/timetable.png""");
            BeginWriteAttribute("alt", " alt=\"", 2001, "\"", 2007, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""table-responsive"">
        <table class=""table table-bordered text-center"">
            <thead>
                <tr class=""bg-light-gray"">
                    <th class=""text-uppercase"">#</th>
                    <th class=""text-uppercase"">Monday</th>
                    <th class=""text-uppercase"">Tuesday</th>
                    <th class=""text-uppercase"">Wednesday</th>
                    <th class=""text-uppercase"">Thursday</th>
                    <th class=""text-uppercase"">Friday</th>
                    <th class=""text-uppercase"">Saturday</th>
                    <th class=""text-uppercase"">Sunday</th>
                </tr>
                <tr>
                    <th class=""text-uppercase""></th>
");
#nullable restore
#line 60 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                     foreach (var date in ViewBag.Date)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th class=\"text-uppercase\">");
#nullable restore
#line 62 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                              Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 63 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 67 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                 foreach (Slot slot in ViewBag.slot)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            Slot ");
#nullable restore
#line 71 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                            Write(slot.SlotId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 73 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                         if (map.ContainsKey(@slot.SlotId))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                             foreach (String date in ViewBag.Date)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                 if (map.Values.ElementAt(@slot.SlotId-1).ContainsKey(date))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <div><b>");
#nullable restore
#line 80 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                           Write(map.Values.ElementAt(@slot.SlotId-1).Values.ElementAt(0).Subject.SubjectCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>  </div>\r\n                                        <div>\r\n                                            ");
#nullable restore
#line 82 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                       Write(map.Values.ElementAt(@slot.SlotId-1).Values.ElementAt(0).Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>(");
#nullable restore
#line 83 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                          Write(slot.SlotTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n");
#nullable restore
#line 84 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                         if (map.Values.ElementAt(@slot.SlotId-1).Values.ElementAt(0).Status == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:green\">\r\n                                                Attend\r\n                                            </span>\r\n");
#nullable restore
#line 89 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:red\">\r\n                                                Not yet\r\n                                            </span>\r\n");
#nullable restore
#line 95 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n");
#nullable restore
#line 97 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <div><b>-</b>  </div>\r\n                                    </td>\r\n");
#nullable restore
#line 103 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                             
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 136 "D:\S5\ProjectPRN192\StudentManagement\StudentManagement\Views\Student\TimeTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
