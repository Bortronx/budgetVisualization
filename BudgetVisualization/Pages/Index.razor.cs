using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetVisualization.Pages
{
    public partial class Index
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public bool IsMobile { get; set; }

        protected override async Task OnInitializedAsync()
        {
            

            IsMobile = await CheckIsMobile();

        }

        public async Task<bool> CheckIsMobile()
        {
            var dimension = await Service.GetDimensions();
            System.Console.WriteLine("Dimensions: " +  dimension.Height + "h " + dimension.Width + "w");

            return (dimension.Height / dimension.Width) > 1 ;
        }

        async Task GetDimensions()
        {
            var dimension = await Service.GetDimensions();
            Height = dimension.Height;
            Width = dimension.Width;
        }
    }
}
