using System;
using System.Threading.Tasks;

namespace BudgetVisualization.Pages
{
    public partial class Index
    {
        protected override async Task OnInitializedAsync()
        {
            // Subscribe to the StateChanged EventHandler
            AppState.StateChanged +=
                AppStateHasChanged;

            System.Console.WriteLine("Index Initialized");

        }

        // This method is fired when the AppState object
        // invokes its StateHasChanged() method
        void AppStateHasChanged(
            object sender, EventArgs e) => StateHasChanged();



    }
}
