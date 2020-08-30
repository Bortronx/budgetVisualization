using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Data
{
    public class BudgetSection
    {
        public string SectionName;

        public string Icon = "supervised_user_circle";

        public List<ProposedItem> ProposedItems;

        public BudgetSection(string sectionName, List<ProposedItem> proposedItems)
        {
            SectionName = sectionName;

            ProposedItems = proposedItems;
        }

    }
}
