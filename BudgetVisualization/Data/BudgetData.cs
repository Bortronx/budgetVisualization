using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Data
{
    public class BudgetData
    {
        public List<BudgetSection> BudgetSections;

        // The index within the Budget Section list of the item being compared to
        public int sectionBeingComparedIndex = 1;

        public string sectionBeingComparedName;

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

            AddBudgetSection("Policing",
                 new List<ProposedItem>
                 {

                    new ProposedItem(
                        "45 New Police Officer Positions",
                        2409966,
                        53555,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "Helicopter fleet",
                        24000000,
                        6000000,
                        "http://picsum.photos/150/150",
                        0),
                    new ProposedItem(
                        "Cloud-basedfingerprintIDsystem",
                        1500000,
                        1500000,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "LawEnforcementRecordsManagementSystem",
                        10500000,
                        10500000,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "ArmoredMedicalVehicle",
                        10500000,
                        10500000,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "Correctionscivilianpositions",
                        2870000,
                        2870000,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "AdministrativeOfficeoftheCourts",
                        18963000,
                        18963000,
                        "http://picsum.photos/150/150",
                        0),

                    new ProposedItem(
                        "StateAttorney",
                        9814000,
                        9814000,
                        "http://picsum.photos/150/150",
                        0),
                 });



        }

        public void AddBudgetSection(string sectionName, List<ProposedItem> proposedItems)
        {
            BudgetSections.Add(new BudgetSection(sectionName, proposedItems));
        }

        public BudgetSection GetCurrentComparedToSection()
        {
            return BudgetSections[sectionBeingComparedIndex];
        }

        public BudgetSection GetSection(string sectionName)
        {
            return BudgetSections.Find(x => x.SectionName.Contains(sectionName));
        }

    }
}
