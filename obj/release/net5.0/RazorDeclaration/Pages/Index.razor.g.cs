// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace frontAppProjet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using frontAppProjet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/_Imports.razor"
using frontAppProjet.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/Pages/Index.razor"
       
    private string error = "Merci de rentrer vos identifiants";
    private string email;
    private string password;
    private clicker.model.User user;
    private async void ConnexionVerification()
    {
        try
        {
            user = await Http.GetFromJsonAsync<clicker.model.User>("https://micheul.alwaysdata.net/User/Connect?email=" +
            email +
            "&password=" + password);
            UriHelper.NavigateTo("/counter/" + user.Id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            error = "Email ou Mot de passe faux";
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
