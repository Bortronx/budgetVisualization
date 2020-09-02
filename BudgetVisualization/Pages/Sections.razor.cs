using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BudgetVisualization.Data;
namespace BudgetVisualization.Pages
{
    public partial class Sections
    {
        [Inject]
        protected BudgetData BudgetData { get; set; }

        public float CalculatedComparisonValue { get; set; }

        public string ComparisonUnit { get; set; }


        protected override async Task OnInitializedAsync()
        {


            System.Console.WriteLine("Sections Initialized");

        }

        protected override void OnInitialized()
        {
            
        }

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
