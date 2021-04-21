using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BudgetVisualization.Components
{
    public partial class CampaignSection
    {
        [Parameter]
        public string CampaignName { get; set; }

        [Parameter]
        public RenderFragment CampaignDescription { get; set; }

        [Parameter]
        public string CampaignActionTitle { get; set; }

        [Parameter]
        public RenderFragment CampaignActionContent { get; set; }
      
        [Parameter]
        public string CampaignImage { get; set; } // TODO: Implement
    }
}
