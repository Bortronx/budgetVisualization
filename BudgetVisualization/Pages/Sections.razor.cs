using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BudgetVisualization.Data;
namespace BudgetVisualization.Pages
{
    public partial class Sections
    {
        [Inject]
        protected BudgetData BudgetData { get; set; }

        [Parameter]
        public string SectionName { get; set; }


        //<-- Comparison
        public float CalculatedComparisonValue { get; set; }

        public string ComparisonUnit { get; set; }

        public string CurrentComparisonText { get; set; } = "Select the items to compare them.";

        public string CurrentComparisonImage { get; set; }



        

        //<-- Proposed Items
        public int rowRightActiveIndex;

        public ProposedItem rowRightItem;

        public int rowLeftActiveIndex;

        public ProposedItem rowLeftItem;

        //Style
        private string selectedStyle = "background-color: darkgray;";

        private string unselectedStyle = "";
        


        protected override async Task OnInitializedAsync()
        {


            System.Console.WriteLine("Sections Initialized");

        }

        protected override void OnInitialized()
        {
            
        }

        public void SetItemSelectedRight(int index, ProposedItem rightItem)
        {
            rowRightActiveIndex = index;

            rowRightItem = rightItem;

            Compare();
        }

        public void SetItemSelectedLeft(int index, ProposedItem leftItem)
        {
            rowLeftActiveIndex = index;

            rowLeftItem = leftItem;

            Compare();
        }

        public void Compare()
        {
            
            if (rowLeftItem != null && rowRightItem != null)
            {
                System.Console.WriteLine("RESULT:" + rowRightItem.ItemName + rowLeftItem.ItemName);

                //GetComparisonResult(rowLeftItem.ItemValue, rowRightItem.BudgetValue, rowLeftItem.SelectionType);

                CurrentComparisonText = BudgetData.PreMadeComparsionResults[(rowLeftActiveIndex * BudgetData.GetCurrentComparedToSection()
                    .ProposedItems.Count)  + rowRightActiveIndex];

                StateHasChanged();
            }
            
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
