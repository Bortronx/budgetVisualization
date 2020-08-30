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
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                });

            AddBudgetSection("Transportation",
                 new List<ProposedItem>
                 {
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                 });

            AddBudgetSection("Judicial Administration",
                 new List<ProposedItem>
                 {
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                 });

            AddBudgetSection("Housing",
                 new List<ProposedItem>
                 {
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                 });

            AddBudgetSection("Juvenile Services",
                 new List<ProposedItem>
                 {
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                    new ProposedItem(ItemName: "Item 1", ItemValue: 1000, BudgetValue: 1000, percent: 0.1f,
                    imageURL: "https://picsum.photos/200/200"),
                 });


        }

        public void AddBudgetSection(string sectionName, List<ProposedItem> proposedItems)
        {
            BudgetSections.Add(new BudgetSection(sectionName, proposedItems));
        }

    }
}
