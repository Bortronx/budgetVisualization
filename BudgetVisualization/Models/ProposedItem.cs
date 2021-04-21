using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Models
{
    public class ProposedItem
    {
        public string ItemName { get; set; }

        public double ItemValue { get; set; }

        public float BudgetValue { get; set; }

        public string budgetValueTypeName;

        public float percentChange { get; set; }

        public bool Active { get; set; }

        public string SelectionType { get; set; }

        public string imageURL { get; set; }

        public string ItemStyle { get; set; }

        private string activeStyle;

        private string baseStyle;

        public ProposedItem(
            string ItemName, 
            double ItemValue,
            int BudgetValue,
            string imageURL,
            float percentChange = 0,
            string budgetValueTypeName = "Proposed")
        {
            this.ItemName = ItemName;
            this.ItemValue = ItemValue;
            this.BudgetValue = BudgetValue;
            this.imageURL = imageURL;
            this.percentChange = percentChange;
            this.budgetValueTypeName = budgetValueTypeName;

            ItemStyle = baseStyle;
        }


        public void SetActive()
        {
            ItemStyle = activeStyle;
        }

        public void SetInactive()
        {

        }
    }
}
