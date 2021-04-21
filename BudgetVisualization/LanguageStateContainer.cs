using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization
{
    public class LanguageStateContainer
    {
        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
