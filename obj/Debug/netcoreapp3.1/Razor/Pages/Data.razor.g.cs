#pragma checksum "E:\Uni\DNP\WebApplication7\Pages\Data.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f98bd9d503bbdda42b2f749482c654db60f4f9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using WebApplication7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Uni\DNP\WebApplication7\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Uni\DNP\WebApplication7\Pages\Data.razor"
using WebApplication7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Uni\DNP\WebApplication7\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data")]
    public partial class Data : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""hero is-medium is-primary is-bold"">
      <div class=""hero-body"">
        <div class=""container"">
          <h1 class=""title"">Welcome to assignment 1</h1>
          <h2 class=""subtitle"">Please select one of the <strong>buttons</strong>, to see and manipulate Adult data.</h2>
        </div>
      </div>
    </section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Uni\DNP\WebApplication7\Pages\Data.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }
    private String adultInfo;
    
   protected override async Task OnInitializedAsync()
   {
       var auth = await AuthenticationState;
   
       if (auth.User.Identity.IsAuthenticated)
       {
           adultInfo = Service.getAdults()[0].JobTitle;
       }
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
