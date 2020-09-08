using System;
using System.Threading.Tasks;
using BudgetVisualization.Services;
using Microsoft.AspNetCore.Components;

namespace BudgetVisualization.Shared
{
    public partial class MainLayout
    {
        //[Inject]
        //protected BrowserService BrowserService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //// Subscribe to the StateChanged EventHandler
            //AppState.StateChanged +=
            //    AppStateHasChanged;


            //System.Console.WriteLine("Main Layout Initialized");

            //AppState.IsMobile = await BrowserService.CheckIsMobile();

            //System.Console.WriteLine("Main Layout Initialized 2");

            //AppState.StateHasChanged();
        }


        // This method is fired when the AppState object
        // invokes its StateHasChanged() method
        //void AppStateHasChanged(
        //    object sender, EventArgs e) => StateHasChanged();

    }
}
