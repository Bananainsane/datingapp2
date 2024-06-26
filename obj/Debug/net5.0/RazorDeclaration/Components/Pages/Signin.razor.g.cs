// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DatingApp.Components.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\code\datingapp2\Components\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\code\datingapp2\Components\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\code\datingapp2\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\code\datingapp2\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\code\datingapp2\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\code\datingapp2\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\code\datingapp2\Components\_Imports.razor"
using DatingApp.Components.Layout

#nullable disable
    ;
#nullable restore
#line 8 "C:\code\datingapp2\Components\_Imports.razor"
using static Microsoft.AspNetCore.Components.Web.RenderMode

#nullable disable
    ;
#nullable restore
#line 10 "C:\code\datingapp2\Components\_Imports.razor"
using DatingApp

#nullable disable
    ;
#nullable restore
#line 11 "C:\code\datingapp2\Components\_Imports.razor"
using BlazorBootstrap

#nullable disable
    ;
#nullable restore
#line 5 "C:\code\datingapp2\Components\Pages\Signin.razor"
 using DatingApp.Models

#nullable disable
    ;
#nullable restore
#line 6 "C:\code\datingapp2\Components\Pages\Signin.razor"
 using System.Linq

#nullable disable
    ;
#nullable restore
#line 7 "C:\code\datingapp2\Components\Pages\Signin.razor"
 using Microsoft.EntityFrameworkCore

#nullable disable
    ;
#nullable restore
#line 10 "C:\code\datingapp2\Components\Pages\Signin.razor"
 using Microsoft.JSInterop

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\code\datingapp2\Components\Pages\Signin.razor"
      "/Signin"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Signin : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\code\datingapp2\Components\Pages\Signin.razor"
       
    [SupplyParameterFromForm]
    private User user { get; set; } = new();
    private string errorMessage;

    protected override void OnInitialized()
    {
        if (UserService.IsLoggedIn)
        {
            JSRuntime.InvokeVoidAsync("alert", "You are already Logged In..");
            NavigationManager.NavigateTo($"/user/{UserService.Id}");
        }
    }

    private async Task LoginPage()
    {
        var authenticatedUser = await DB.Users
            .FirstOrDefaultAsync(u => u.Login == user.Login && u.Password == user.Password);

        if (authenticatedUser != null)
        {
            UserService.Id = authenticatedUser.Id;
            UserService.FirstName = authenticatedUser.FirstName;
            UserService.LastName = authenticatedUser.LastName;
            UserService.Email = authenticatedUser.Email;
            UserService.Login = authenticatedUser.Login;
            UserService.IsLoggedIn = true;

            NavigationManager.NavigateTo($"/user/{authenticatedUser.Id}");
        }
        else
        {
            errorMessage = "Invalid username or password. Please try again.";
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 9 "C:\code\datingapp2\Components\Pages\Signin.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 9 "C:\code\datingapp2\Components\Pages\Signin.razor"
                   JSRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\code\datingapp2\Components\Pages\Signin.razor"
        DatingApp.Services.UserService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\code\datingapp2\Components\Pages\Signin.razor"
                                       UserService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\code\datingapp2\Components\Pages\Signin.razor"
        DatingApp.Data.DatingContext

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\code\datingapp2\Components\Pages\Signin.razor"
                                     DB

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\code\datingapp2\Components\Pages\Signin.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\code\datingapp2\Components\Pages\Signin.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
