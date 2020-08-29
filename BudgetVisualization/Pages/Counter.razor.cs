using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Pages
{
    public partial class Counter
    {

        private string item1Name = "PoliceCar";

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

        protected override void OnInitialized()
        {
            System.Console.WriteLine("Hello");


        }
    }
}
