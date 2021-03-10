using System.Collections.Generic;
using BudgetVisualization.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BudgetVisualization.Data
{
    public class BudgetData
    {

        public List<BudgetSection> BudgetSections;

        // The index within the Budget Section list of the item being compared to
        public int sectionBeingComparedIndex = 1;

        public string sectionBeingComparedName;

        //TODO REMOVE WHEN AUTOMATED
        public List<string> PreMadeComparsionResults;

        public List<string> PreMadeComparsionResultsLinks;

        public BudgetData()
        {
            BudgetSections = new List<BudgetSection>();

            // TODO: Move this information to the resource files
            AddBudgetSection("Community Services",
                new List<ProposedItem>
                {
                    new ProposedItem(ItemName: "Employment and Training", ItemValue: 1000, BudgetValue: 216000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/08/Empolyment-and-Training.jpg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Neighborhood Centers/ Community Resource Centers", ItemValue: 1000, BudgetValue: 3471000,
                    imageURL: "https://miamidsa.org/wp-content/uploads/2020/09/Public-Housing-and-Community-Development.jpg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Psychological Services", ItemValue: 1000, BudgetValue: 284000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/09/Psycological-Services.jpg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Rehabilitative Service", ItemValue: 1000, BudgetValue: 3408000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/09/Rehabilitation.svg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Violence Prevention & Intervention", ItemValue: 1000, BudgetValue: 4472000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/09/Stop-Violence.svg",  percentChange: 0.1f),
                    new ProposedItem(ItemName: "Public Defender", ItemValue: 1000, BudgetValue: 4832000,
                    imageURL: "http://miamidsa.org/wp-content/uploads/2020/08/Defender.svg",  percentChange: 0.1f),
                });

            // TODO: Move this information to the resource files
            AddBudgetSection("Policing",
                 new List<ProposedItem>
                 {

                    new ProposedItem(
                        "45 New Police Officer Positions",
                        53555,
                        2409966,
                        "http://miamidsa.org/wp-content/uploads/2020/08/45officers.svg",
                        0,
                        "Approximately"),

                    new ProposedItem(
                        "Helicopter fleet",
                        6000000,
                        24000000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/New-Police-Helicopters.jpg",
                        0),
                    new ProposedItem(
                        "Video cameras & license plate readers",
                        6900000,
                        6900000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/Video-Cameras-and-License-Plate-Readers.jpg",
                        0),
                    new ProposedItem(
                        "Cloud-based fingerprint ID system",
                        1500000,
                        1500000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/FingerprintIDSystem.svg",
                        0),

                    new ProposedItem(
                        "Law Enforcement Records Management System",
                        1871000,
                        1871000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/LawEnforcementRecordsSystem.svg",
                        0),

                    new ProposedItem(
                        "Armored Medical Vehicle",
                        303000,
                        303000,
                        "http://miamidsa.org/wp-content/uploads/2020/08/armoredvehicle.svg",
                        0),

                    new ProposedItem(
                        "Increase to Corrections Salaries",
                        2870000,
                        2870000,
                        "http://miamidsa.org/wp-content/uploads/2020/08/Civilian-Correction-Officer.svg",
                        0),

                    new ProposedItem(
                        "Administrative Office of the Courts",
                        18963000,
                        18963000,
                        "http://miamidsa.org/wp-content/uploads/2020/08/Administrative-Office-of-the-Courts.svg",
                        0),

                    new ProposedItem(
                        "State Attorney",
                        9814000,
                        9814000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/Prosecutor.svg",
                        0),
                 });


            // TODO REMOVE WHEN AUTOMATED
            CreatePremadeComparisons();
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

        /// <summary>
        /// Populates comparison results using .resx file text instead
        /// of having a large text block list in the class itself.
        /// The goal is to move most of the text to .resx (resource) files
        /// making it easier to change and translate these files in the future.
        /// </summary>
        public void CreatePremadeComparisons()
        {
            PreMadeComparsionResultsLinks = new List<string>()
            {

            };

            // This number is obtained from the resource file total Comparisons
            int numOfSectionResxComparisons = 54;

            PreMadeComparsionResults = new List<string>();

            for (int i = 0; i < numOfSectionResxComparisons; i++)
            {
                PreMadeComparsionResults.Add("Comparison #" + i);
            }
        }

    }
}
