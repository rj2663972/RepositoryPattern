#pragma checksum "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02ed6f74a092d037d175a0b48d4fe9e6dc94624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\_ViewImports.cshtml"
using RP.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\_ViewImports.cshtml"
using RP.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02ed6f74a092d037d175a0b48d4fe9e6dc94624", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e845057efb48a843de580b8abe04ad4102c40b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RP.Domain.Entities.UserAgg.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">Age</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 24 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
                       Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
           Write(user.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "E:\Rahul\GitProjects\RepositoryPattern\RepoPattern\RP.Web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RP.Domain.Entities.UserAgg.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
