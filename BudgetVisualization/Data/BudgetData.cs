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

            AddBudgetSection("Community Services",
                new List<ProposedItem>
                {
                    new ProposedItem(ItemName: "Employment and Training", ItemValue: 1000, BudgetValue: 216000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/08/Empolyment-and-Training.jpg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Neighborhood Centers/ Community Resource Centers", ItemValue: 1000, BudgetValue: 3471000,
                    imageURL: "https://picsum.photos/200/200",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Psychological Services", ItemValue: 1000, BudgetValue: 284000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/09/Psycological-Services.jpg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Rehabilitative Service", ItemValue: 1000, BudgetValue: 3408000,
                    imageURL: "https://picsum.photos/200/200",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Violence Prevention & Intervention", ItemValue: 1000, BudgetValue: 4472000,
                    imageURL: "https://picsum.photos/200/200",  percentChange: 0.1f),
                });

            AddBudgetSection("Transportation",
                 new List<ProposedItem>
                 {
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000,
                    imageURL: "https://picsum.photos/200/200",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000,
                    imageURL: "https://picsum.photos/200/200",  percentChange: 0.1f),
                 });



        }

        public void AddBudgetSection(string sectionName, List<ProposedItem> proposedItems)
        {
            BudgetSections.Add(new BudgetSection(sectionName, proposedItems));
        }

    }
}
