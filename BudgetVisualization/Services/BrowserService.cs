using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BudgetVisualization.Services
{
    public class BrowserService
    {
        public class BrowserDimension
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }

        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }

        public async Task<bool> CheckIsMobile()
        {
            var dimension = await GetDimensions();
            System.Console.WriteLine("Dimensions: " + dimension.Height + "h " + dimension.Width + "w");

            float height = dimension.Height;
            float width = dimension.Width;

            System.Console.WriteLine("Dimensions ratio: " + ((height / width) > 1.0f));

            return (height / width) > 1.0f;
        }
    }
}
