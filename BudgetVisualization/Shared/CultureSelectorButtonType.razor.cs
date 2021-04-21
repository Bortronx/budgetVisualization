using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BudgetVisualization.Shared
{
    public partial class CultureSelectorButtonType : IDisposable
    {
        [Inject] 
        IJSRuntime JSRuntime { get; set; }

        [Inject]
        NavigationManager Nav { get; set; }

        [Inject]
        public LanguageStateContainer LanguageState { get; set; }


        [Parameter]
        public int LanguageIndex { get; set; }

        string dropdownMenuStyleSelected = "display:none;";
        string dropdownMenuStyle = "localization-dropdown";

        
        CultureInfo[] supportedCultures = new[]
        {
        new CultureInfo("en-US"),
        new CultureInfo("es-ES"),
    };

        CultureInfo Culture
        {
            get => CultureInfo.CurrentCulture;
            set
            {


                if (CultureInfo.CurrentCulture != value)
                {
                    var js = (IJSInProcessRuntime)JSRuntime;
                    js.InvokeVoid("blazorCulture.set", value.Name);
                    js.InvokeVoid("blazorCulture.set", value.Name);


                    Nav.NavigateTo(Nav.Uri, forceLoad: true);
                }


            }
        }

        protected override void OnInitialized()
        {
            LanguageState.OnChange += ChangeCultureToNext;
        }

        public void Dispose()
        {
            LanguageState.OnChange -= ChangeCultureToNext;
        }

        public void ChangeCultureToNext()
        {
            for (int i = 0; i < supportedCultures.Length; i++)
            {
                if (Culture.Equals(supportedCultures[i]))
                {
                    // Index of next culture in array
                    int index = (i + 1) % supportedCultures.Length; 

                    // Set new culture
                    Culture = supportedCultures[index];

                    break;
                }
            }


        }

        protected override void OnParametersSet()
        {
           
        }
    }
}
