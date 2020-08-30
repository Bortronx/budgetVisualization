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

        public float CalculatedComparisonValue { get; set; }

        public string ComparisonUnit { get; set; }

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


        //caluclating comparison (we will probably have to change this based on what the data we are getting looks like)

        //what we want:
        //calculate the amount of a community item that can be funded using the funds from a police item

        //what we need:
        //selection type: unit (i.e. years, buildings, etc.)
        //cost of a single unit of community item (1 year of employment training = $10,000 [CommunityBudgetItemValue])
        //total cost of a set number of police items (i.e. 4 helicopters = $315,000 [PoliceBudgetItemValue])

        public void GetComparisonResult(float CommunityBudgetItemValue, float PoliceBudgetItemValue,
               string SelectionType)
        {
            this.CalculatedComparisonValue = PoliceBudgetItemValue / CommunityBudgetItemValue;
            this.ComparisonUnit = SelectionType;
        }


    }
}
