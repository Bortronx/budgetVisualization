using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BudgetVisualization.Components
{
    public partial class ComparisonResultStatic
    {
        [Parameter]
        public string ComparisonText { get; set; }

        [Parameter]
        public string ImagePath { get; set; }

        [Parameter]
        public string FirstImagePath { get; set; }

        [Parameter]
        public string SecondImagePath { get; set; }

        [Parameter]
        public IStringLocalizer Localizer { get; set; }
    }
}
