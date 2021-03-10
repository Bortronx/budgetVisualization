using BudgetVisualization.Data;
using BudgetVisualization.Models;
using BudgetVisualization.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Components
{
    public partial class ProposedBudgetItem
    {
        [Parameter]
        public ProposedItem itemData { get; set; }

        [Parameter]
        public IStringLocalizer Localizer { get; set; }

        string color;

        string defaultColor = "#accce7";
        string activeColor = "#86abca";

    }
}
