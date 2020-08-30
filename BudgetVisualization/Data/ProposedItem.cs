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

    }
}
