#pragma checksum "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4002fa8a7a9f7024d97203cc3817c55a22b4bae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DetailsMovie), @"mvc.1.0.view", @"/Views/Movie/DetailsMovie.cshtml")]
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
#line 1 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\_ViewImports.cshtml"
using MovieTheater;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\_ViewImports.cshtml"
using MovieTheater.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4002fa8a7a9f7024d97203cc3817c55a22b4bae4", @"/Views/Movie/DetailsMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02af776d0317e24ceefdd367851f1a714110b937", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DetailsMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieTheater.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
  
    ViewData["Title"]  = "DetailsMovie";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr/>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\" hidden>\r\n            ");
#nullable restore
#line 11 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" hidden>\r\n            ");
#nullable restore
#line 14 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayNameFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n           ");
#nullable restore
#line 47 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
      Write(Html.DisplayNameFor(model=>model.RelaseDateOf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\MSAD\Desktop\Repositorio visual\MovieTheater\Views\Movie\DetailsMovie.cshtml"
       Write(Html.DisplayFor(model=>model.RelaseDateOf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieTheater.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591