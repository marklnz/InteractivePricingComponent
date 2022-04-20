using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingComponent.Components
{
    public partial class Slider : ComponentBase
    {

        [Parameter]
        public int MinValue { get; set; }
        [Parameter]
        public int MaxValue { get; set; }
        [Parameter]
        public int Step { get; set; }
        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public EventCallback<int> ValueChanged { get; set; }

        private async Task HandleInputChange(ChangeEventArgs e)
        {
            if (Int32.TryParse(e.Value.ToString(), out int value))
            {
                Value = value;

                Console.WriteLine($"Value = {Value}");

                await ValueChanged.InvokeAsync(Value);
            }
        }

        // Evaluate the percentage that the current Value represents, given the Max and Min values. 
        // This is used to keep the background size of the coloured component in the slider track in sync
        // with the position of the slider's thumb button
        private string GetPercentage()
        {
            int percentage = (Value - MinValue) * 100 / (MaxValue - MinValue);
            return $"{percentage}%";
        }

    }
}
