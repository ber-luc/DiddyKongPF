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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter/{Id:int}")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/lucberghof/Documents/Dotnet2cours/exempleCours/frontAppProjet/Pages/Counter.razor"
       
    [Parameter]
    public int Id { get; set; }
    private double currentCount = 10000;
    private int clickMe;
    private int pointTimer;

    private double clickMePrice;

    private double clickMeIncr = 110;
    private int timerDelay = 3000;

    private double timerPrice;
    private double TimerIncr = 110;
    private int TimeActual;
    private string message = "";
    private clicker.model.User user;



    protected override async Task OnInitializedAsync()
    {
        try
        {
            user = await Http.GetFromJsonAsync<clicker.model.User>("https://micheul.alwaysdata.net/User/Load?id=" + Id);

        }
        catch (Exception e)
        {
            UriHelper.NavigateTo("/");
        }

        InitialisationToConnect();
        SetTimer();
        for (int i = 0; i < 3; i++)
        {
            i = 0;
            currentCount = currentCount + pointTimer;
            await Task.Delay(timerDelay);
            StateHasChanged();
        }
    }

    private void InitialisationToConnect()
    {
        Random aleatoire = new Random();
        TimerIncr = aleatoire.Next(95, 105);
        timerPrice = Math.Ceiling((user.TimerPower) * TimerIncr);
        pointTimer = user.TimerPower;
        currentCount = user.Score;
        clickMe = user.ClickPower;
        clickMeIncr = aleatoire.Next(95, 105);
        clickMePrice = Math.Ceiling((user.ClickPower) * clickMeIncr);
        TimeActual = user.Playtime;
        TimeActualSecond = user.Playtime % 60;
        TimeActualMinute = (user.Playtime / 60) % 60;
        TimeActualHour = ((user.Playtime / 60) / 60) % 60;
    }

    private void IncrementCount()
    {
        currentCount = currentCount + clickMe;
    }

    private void IncrementClickMe()
    {
        if (currentCount >= clickMePrice)
        {
            currentCount = currentCount - clickMePrice;
            clickMe++;
            Random aleatoire = new Random();

            clickMeIncr = aleatoire.Next(95, 105);
            clickMePrice = Math.Ceiling((clickMe) * clickMeIncr);
            message = "Félicitation pour ce merveilleux achat";
        }
        else
        {
            message = "Vous êtes trop pauvre";
        }
    }

    private void IncrementTimer()
    {
        if (currentCount >= timerPrice)
        {
            currentCount = currentCount - timerPrice;
            pointTimer++;
            Random aleatoire = new Random();

            TimerIncr = aleatoire.Next(95, 105);
            timerPrice = Math.Ceiling((pointTimer) * TimerIncr);
            message = "Félicitation pour ce merveilleux achat";
        }
        else
        {
            message = "Vous êtes trop pauvre";
        }
    }

    private long TimeActualHour = 00;
    private long TimeActualMinute = 00;
    private long TimeActualSecond = 00;

    private void SetTimer()
    {
        // Create a timer with a two second interval.
        System.Timers.Timer aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer.
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        TimeActual++;
        TimeActualSecond++;
        if (TimeActualSecond >= 60)
        {
            TimeActualMinute++;
            TimeActualSecond = 0;
        }
        if (TimeActualMinute >= 60)
        {
            TimeActualHour++;
            TimeActualMinute = 0;
        }
        StateHasChanged();
    }
    public void Dispose()
    {
        System.Console.WriteLine("salutperper");
    }

    private async void RegisterScore()
    {
        clicker.model.User UserToSave = new clicker.model.User()
        {
            Id = user.Id,
            Email = user.Email,
            Password = user.Password,
            Score = currentCount,
            ClickPower = clickMe,
            TimerPower = pointTimer,
            Playtime = TimeActual,
            Token = ""
        };
        await Http.PutAsJsonAsync<clicker.model.User>("https://micheul.alwaysdata.net/User/Save", UserToSave);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591