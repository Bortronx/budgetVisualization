#pragma checksum "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\Components\ProposedBudgetItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6e1fa63e1977136c0525ac6d2d0fca84f65734"
// <auto-generated/>
#pragma warning disable 1591
namespace BudgetVisualization.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using BudgetVisualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using BudgetVisualization.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class ProposedBudgetItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mat-layout-grid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mat-layout-grid-cell");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddContent(9, 
#nullable restore
#line 4 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\Components\ProposedBudgetItem.razor"
             ItemName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "mat-layout-grid-cell");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\Components\ProposedBudgetItem.razor"
             ItemValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\PROJECTS\POLITICAL_BUDGET_VISUALIZATION\APP\budgetVisualization\BudgetVisualization\Components\ProposedBudgetItem.razor"
       

    [Parameter]
    public string ItemName { get; set; }

    [Parameter]
    public float ItemValue { get; set; }


    protected override void OnParametersSet()
    {
        System.Console.WriteLine(" Parameters" + ItemName);
    }

    protected override void OnInitialized()
    {
        System.Console.WriteLine("Initialized" + ItemName);

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
