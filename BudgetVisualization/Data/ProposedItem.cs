using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Data
{
    public class ProposedItem
    {

        public string ItemName { get; set; }

        public float ItemValue { get; set; }

        public float BudgetValue { get; set; }

        public float percent { get; set; }

        public bool Active { get; set; }

        public string SelectionType { get; set; }
        
        public ProposedItem(string ItemName, float ItemValue, float BudgetValue, float percent, bool Active, string SelectionType)
        {
            this.ItemName = ItemName;
            this.ItemValue = ItemValue;
            this.BudgetValue = BudgetValue;
            this.percent = percent;
            this.Active = Active;
            this.SelectionType = SelectionType;

        }

    }
}
