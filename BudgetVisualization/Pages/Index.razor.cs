using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BudgetVisualization.Pages
{
    public partial class Index
    {
        [Parameter]
        public string SectionName { get; set; }

        public string DefaultSectionName { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

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
