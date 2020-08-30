using BudgetVisualization.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BudgetVisualization.Shared
{
    public partial class NavMenu
    {
        [Inject]
        protected BudgetData BudgetData { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Subscribe to the StateChanged EventHandler
            AppState.StateChanged +=
                AppStateHasChanged;


            CreateData();

        }

        // This method is fired when the AppState object
        // invokes its StateHasChanged() method
        void AppStateHasChanged(
        object sender, EventArgs e) => StateHasChanged();


        public void CreateData()
        {           
            System.Console.WriteLine("Section Count: " + BudgetData.BudgetSections.Count);
        }

    }
}
