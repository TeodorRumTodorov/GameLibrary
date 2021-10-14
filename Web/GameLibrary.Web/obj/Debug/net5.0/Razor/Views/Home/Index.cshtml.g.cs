#pragma checksum "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81b461577d59db0bdce210ce314cf62df632360"
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
#line 1 "D:\GameLibrary\Web\GameLibrary.Web\Views\_ViewImports.cshtml"
using GameLibrary.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GameLibrary\Web\GameLibrary.Web\Views\_ViewImports.cshtml"
using GameLibrary.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
using GameLibrary.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81b461577d59db0bdce210ce314cf62df632360", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9859db6fc047087a6239bebf3f8738824d8736b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameLibrary.Web.ViewModels.Index.EntityCount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 8 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
                                Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <ul>\r\n        <li>Categories:");
#nullable restore
#line 11 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
                  Write(Model.CategoriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Games:");
#nullable restore
#line 12 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
             Write(Model.GamesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Publishers:");
#nullable restore
#line 13 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
                  Write(Model.PublishersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Creators:");
#nullable restore
#line 14 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
                Write(Model.CreatorsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>AplicationUsers:");
#nullable restore
#line 15 "D:\GameLibrary\Web\GameLibrary.Web\Views\Home\Index.cshtml"
                       Write(Model.AplicationUsersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameLibrary.Web.ViewModels.Index.EntityCount> Html { get; private set; }
    }
}
#pragma warning restore 1591
