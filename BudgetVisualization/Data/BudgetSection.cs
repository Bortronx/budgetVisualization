using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Data
{
    public class BudgetSection
    {
        public string SectionName;

        public List<ProposedItem> ProposedItems;

        public BudgetSection(string sectionName)
        {
            SectionName = sectionName;
        }

        public void AddProposedItem(string sectionName)
        {
            //.Add(new BudgetSection(sectionName));
        }

    }
}
