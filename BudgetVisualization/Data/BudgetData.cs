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

        //TODO REMOVE WHEN AUTOMATED
        public List<string> PreMadeComparsionResults;

        public List<string> PreMadeComparsionResultsLinks;

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
                        "http://miamidsa.org/wp-content/uploads/2020/08/45officers.svg",
                        0),

                    new ProposedItem(
                        "Helicopter fleet",
                        24000000,
                        6000000,
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
                        10500000,
                        10500000,
                        "http://miamidsa.org/wp-content/uploads/2020/09/LawEnforcementRecordsSystem.svg",
                        0),

                    new ProposedItem(
                        "Armored Medical Vehicle",
                        10500000,
                        10500000,
                        "http://miamidsa.org/wp-content/uploads/2020/08/armoredvehicle.svg",
                        0),

                    new ProposedItem(
                        "Corrections civilian positions",
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

        public void CreatePremadeComparisons()
        {
            PreMadeComparsionResultsLinks = new List<string>()
            {

            };

                PreMadeComparsionResults = new List<string>()
            {
                "One year of salaries for 45 new police officer positions is equivalent to 11 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The cost of four new police helicopters is equivalent to 111 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The cost of new video cameras and license plate readers is equivalent to 32 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The pricetag on a new cloud-based fingerprint ID system is equivalent to 7 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The bill for a new Law Enforcement Records Management System is equivalent to 49 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The cost of a single Armored Medical Vehicle is equivalent to 1.4 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The increase of dollars spent on salaries for Corrections is equivalent to over 13 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "One year of administrative costs from the General Fund for the Office of the Courts is equivalent to 88 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "The amount of money drawn from the General Fund for the State Attorney is equivalent to more than 45 years of the County's funding for Employment and Training programs that serve at-risk youth and farmworkers.",
                "One year of salaries for 45 new police officer positions is equivalent to 69% of the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The cost of four new police helicopters is 7 times the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The cost of new video cameras and license plate readers is 2 times the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The pricetag on a new cloud-based fingerprint ID system is equivalent to 43% of the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The bill for a new Law Enforcement Records Management System is 3 times the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The cost of a single Armored Medical Vehicle is 8.7% of the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The increase of dollars spent on salaries for Corrections is equivalent to 83% of the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "One year of administrative costs from the General Fund for the Office of the Courts is five and a half times the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "The amount of money drawn from the General Fund for the State Attorney is nearly 3 times the County's funding for the 13 Community Resource Centers through which residents can access the range of social services offered by the County, from computer training to meals for the elderly to substance abuse treatment.",
                "One year of salaries for 45 new police officer positions equals eight (8) and a half times the entire budget of Psychological Services. This division is responsible for providing psychological services to clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention. Despite that responsibililty, the division is staffed by a four-person internship program.",
                "The cost of four new police helicopters equals eighty-four and a half times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The cost of new video cameras and license plate readers equals 24 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The pricetag on a new cloud-based fingerprint ID system equals more than 5 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The bill for a new Law Enforcement Records Management System equals 37 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The cost of a single Armored Medical Vehicle could cover the entire budget of Psychological Services, with $19,000 to spare. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The increase of dollars spent on salaries for Corrections equals 10 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "One year of administrative costs from the General Fund for the Office of the Courts equals 67 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "The amount of money drawn from the General Fund for the State Attorney equals 35 times the entire budget of Psychological Services. This division is responsible for providing counseling and guidance to the clients of many social programs offered by the County, such as Head Start, Family and Community Services, and Violence Prevention and Intervention.",
                "One year of salaries for 45 new police officer positions comes out to 70 percent of what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The cost of four new police helicopters comes out to 7 times what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The cost of new video cameras and license plate readers comes out to 2 times what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The pricetag on a new cloud-based fingerprint ID system comes out to 44% of what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The bill for a new Law Enforcement Records Management System comes out to 3 times what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The cost of a single Armored Medical Vehicle comes out to 9% of what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The increase of dollars spent on salaries for Corrections comes out to 84% of what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "One year of administrative costs from the General Fund for the Office of the Courts comes out to more than five times what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "The amount of money drawn from the General Fund for the State Attorney comes out to nearly 3 times what the County puts toward Rehabilitative Services. This division provides evaluations, referrals, and treatments services for adults suffering with substance abuse. It includes the Diversion and Treatment Program, through which individuals are referred to treatment as an alternative to jail time.",
                "One year of salaries for 45 new police officer positions is 54% of the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The cost of four new police helicopters is more than 5 times the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The cost of new video cameras and license plate readers is one and a half times the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The pricetag on a new cloud-based fingerprint ID system is equivalent to 33% of the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The bill for a new Law Enforcement Records Management System is 2 times the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The cost of a single Armored Medical Vehicle is equivalent to 7% of the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The increase of dollars spent on salaries for Corrections is equivalent to 64% of the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "One year of administrative costs from the General Fund for the Office of the Courts is over 4 times the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "The amount of money drawn from the General Fund for the State Attorney is more than twice (2) the County's funding for the Violence Prevention & Intervention division, which provides shelter, emergency financial assistance, crisis counseling, and legal advocacy to victims of domestic violence as well as counseling and intervention services for youth.",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions",
                "The cost of four new police helicopters",
                "The cost of new video cameras and license plate readers",
                "The pricetag on a new cloud-based fingerprint ID system",
                "The bill for a new Law Enforcement Records Management System",
                "The money directed toward repairs at a police pool facility",
                "The cost of a single Armored Medical Vehicle",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone",
                "The increase of dollars spent on salaries for Corrections",
                "One year of administrative costs from the General Fund for the Office of the Courts",
                "The amount of money drawn from the General Fund for the State Attorney",
                "One year of salaries for 45 new police officer positions is equivalent to 2.9 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The cost of four new police helicopters is equivalent to 29 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The cost of new video cameras and license plate readers is equivalent to 8.3 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The pricetag on a new cloud-based fingerprint ID system is equivalent to 1.8 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The bill for a new Law Enforcement Records Management System is equivalent to 12.6 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The money directed toward repairs at a police pool facility is equivalent to 10% of a yearsworth of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The cost of a single Armored Medical Vehicle is equivalent to 36% of a yearsworth of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone is equivalent to 11.4% of a yearsworth of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The increase of dollars spent on salaries for Corrections is equivalent to 3.4 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "One year of administrative costs from the General Fund for the Office of the Courts is equivalent to 22.8 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "The amount of money drawn from the General Fund for the State Attorney is equivalent to 11.8 years of the County's funding for the Guardian Ad Litem program, which advocates for the interests of children involved in court proceedings.",
                "One year of salaries for 45 new police officer positions equals 6.9 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The cost of four new police helicopters equals 69 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The cost of new video cameras and license plate readers equals 19.8 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The pricetag on a new cloud-based fingerprint ID system equals more than four times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The bill for a new Law Enforcement Records Management System equals 30 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The money directed toward repairs at a police pool facility equals 24% of the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The cost of a single Armored Medical Vehicle equals 87% of the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone equals 27% of the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The increase of dollars spent on salaries for Corrections equals 8.2 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "One year of administrative costs from the General Fund for the Office of the Courts equals more than 54 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "The amount of money drawn from the General Fund for the State Attorney equals more than 28 times the entire budget of the Office of the Director, which provides overall strategy, policy, and direction to the Juvenile Services Department.",
                "One year of salaries for 45 new police officer positions comes out to 52% of what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The cost of four new police helicopters comes out to 5 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The cost of new video cameras and license plate readers comes out to 1.5 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The pricetag on a new cloud-based fingerprint ID system comes out to 32.9% percent of what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The bill for a new Law Enforcement Records Management System comes out to 2.3 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The money directed toward repairs at a police pool facility comes out to 1% of what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The cost of a single Armored Medical Vehicle comes out to 36% of what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The $95,000 destined for a Social Media Analytics Software is the final installment of a $595,000 purchase. This year's contribution alone comes out to 11% of what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The increase of dollars spent on salaries for Corrections comes out to 3.4 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "One year of administrative costs from the General Fund for the Office of the Courts comes out to nearly 23 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "The amount of money drawn from the General Fund for the State Attorney comes out to 11.8 times what the County puts toward the Operation division, which provides centralized intake and screening of arrested juveniles and provides direct services to arrested and at-risk juveniles such as the Violence Intervention Project, anti-gang strategies, and diversion strategies.",
                "One year of salaries for 45 new police officer positions is equivalent to 50% of the total funding of the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The cost of four new police helicopters is 5 times the total funding of the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The cost of new video cameras and license plate readers is nearly one and a half times the total funding of the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The pricetag on a new cloud-based fingerprint ID system is equivalent to 31% of the total funding of the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The bill for a new Law Enforcement Records Management System is more than twice the total funding of the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The increase of dollars spent on salaries for Corrections is equivalent to 60% of the total funding for the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "One year of administrative costs from the General Fund for the Office of the Courts is 4 times the total funding for the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
                "The amount of money drawn from the General Fund for the State Attorney is 2 times the total funding for the Public Defender's Office. The Public Defender provides legal representation for individuals who cannot afford a private attorney.",
            };
        }

    }
}
