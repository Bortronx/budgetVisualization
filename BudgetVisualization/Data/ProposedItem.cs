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

        public float percentChange { get; set; }

        public bool Active { get; set; }

        public string SelectionType { get; set; }

        public string imageURL { get; set; }
        
        public ProposedItem(
            string ItemName, 
            float ItemValue,
            int BudgetValue,
            string imageURL,
            float percentChange = 0)
        {
            this.ItemName = ItemName;
            this.ItemValue = ItemValue;
            this.BudgetValue = BudgetValue;
            this.imageURL = imageURL;
            this.percentChange = percentChange;

        }

    }
}
