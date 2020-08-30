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

        public string imageURL { get; set; }
        
        public ProposedItem(
            string ItemName, 
            float ItemValue,
            int BudgetValue,
            float percent, 
            string imageURL)
        {
            this.ItemName = ItemName;
            this.ItemValue = ItemValue;
            this.BudgetValue = BudgetValue;
            this.percent = percent;
            this.imageURL = imageURL;

        }

    }
}
