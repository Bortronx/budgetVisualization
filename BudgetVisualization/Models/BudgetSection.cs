﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Models
{
    public class BudgetSection
    {
        public string SectionName;

        public string Icon = "supervised_user_circle";

        public List<ProposedItem> ProposedItems;

        public BudgetSection(string sectionName, List<ProposedItem> proposedItems, string icon = "supervised_user_circle")
        {
            SectionName = sectionName;

            ProposedItems = proposedItems;

            Icon = icon;
        }

    }
}
