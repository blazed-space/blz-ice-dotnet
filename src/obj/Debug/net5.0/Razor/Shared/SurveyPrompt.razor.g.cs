#pragma checksum "/home/runner/HomelyEmotionalBlock/BlazorApp/Shared/SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c109cbb8569c5c8eda82b80b240e07b4710aafb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/runner/HomelyEmotionalBlock/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-bug mr-2\" aria-hidden=\"true\"></span>\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "/home/runner/HomelyEmotionalBlock/BlazorApp/Shared/SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\n\t\t\tFeel free to\n      <a target=\"_blank\" class=\"font-weight-bold\" href=\"mailto://brandononlyu@gmail.com\">email me</a></span>\n\t\tor DM me on Discord at ");
            __builder.AddMarkupContent(8, "<span class=\"font-weight-bold\">SixBeeps#1273.</span>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/runner/HomelyEmotionalBlock/BlazorApp/Shared/SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
