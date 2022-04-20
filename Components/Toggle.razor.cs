using Microsoft.AspNetCore.Components;

namespace PricingComponent.Components
{
    public partial class Toggle : ComponentBase
    {
        [Parameter]
        public bool Value { get; set; }

        [Parameter]
        public EventCallback<bool> ValueChanged { get; set; }

        private async Task ToggleClicked()
        {
            Value = !Value;
            await ValueChanged.InvokeAsync(Value);
        }
    }
}
