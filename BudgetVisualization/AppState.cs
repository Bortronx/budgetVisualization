using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization
{
    public static class AppState
    {
        /// <summary>
        /// StateChanged is an event handler used to refresh UI
        /// </summary>
        public static event EventHandler StateChanged;

        public static void StateHasChanged()
        {
            // This will update any subscribers
            // that the dialog state has changed
            // so they can update themselves
            // and show the current dialog values
            StateChanged?.Invoke(null, EventArgs.Empty);
        }


        // Mobile when page dimension ratio (height/widt) is higher than 1
        public static bool IsMobile = false;



    }
}
