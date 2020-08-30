using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Data
{
    public class BudgetData
    {
        public List<BudgetSection> BudgetSections;

        public BudgetData()
        {
            BudgetSections = new List<BudgetSection>();


        }

        public void AddBudgetSection(string sectionName)
        {
            BudgetSections.Add(new BudgetSection(sectionName));
        }

    }
}
