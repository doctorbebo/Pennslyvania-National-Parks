#pragma checksum "/Users/Byron/Projects/Pennslyvania-National-Parks/Pennslyvania-National-Parks/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25ea84f5a812bc3463d1553ae0efa0b9c959496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pennslyvania_National_Parks.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Pennslyvania_National_Parks.Pages
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
#line 1 "/Users/Byron/Projects/Pennslyvania-National-Parks/Pennslyvania-National-Parks/Pages/_ViewImports.cshtml"
using Pennslyvania_National_Parks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25ea84f5a812bc3463d1553ae0efa0b9c959496", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e69ed9fa6285582f5c6ca35700ffc4219e28c722", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Byron/Projects/Pennslyvania-National-Parks/Pennslyvania-National-Parks/Pages/Index.cshtml"
  
    ViewData["Title"] = "Parks page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""text-center"">
    <h1 class=""display-4""> Welcome to Parks</h1>
    <p>
        This little app pulls a list of all the national parks in
        the great state of Pennslyvania from data.gov and displays them in a orderly manner.
    </p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PennslyvaniaNationalParks.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PennslyvaniaNationalParks.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PennslyvaniaNationalParks.Pages.IndexModel>)PageContext?.ViewData;
        public PennslyvaniaNationalParks.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
