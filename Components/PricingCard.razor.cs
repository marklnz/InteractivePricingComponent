using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingComponent.Components
{
    public partial class PricingCard : ComponentBase
    {

        private decimal _price = 0.00M;
        private int _pageviews = 10000;
        private bool _yearlyRate = false;
        private int _value = 3;

        private string CalculatePricePerMonth(int sliderValue) => sliderValue switch
        {
            1 => (8.00m * (_yearlyRate ? .75m : 1)).ToString("0.00"),
            2 => (12.00m * (_yearlyRate ? .75m : 1)).ToString("0.00"),
            3 => (16.00m * (_yearlyRate ? .75m : 1)).ToString("0.00"),
            4 => (24.00m * (_yearlyRate ? .75m : 1)).ToString("0.00"),
            5 => (36.00m * (_yearlyRate ? .75m : 1)).ToString("0.00"),
            _ => "0.00"
        };

        private string FormatNumber(int num)
        {
            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + "M";
            else if (num >= 100000)
                return (num / 1000).ToString() + "K";
            else if (num >= 1000)
                return (num / 1000D).ToString("0.#") + "K";
            else
                return num.ToString("#,0");
        }

        private int GetPageViewCountFromSliderValue(int sliderValue) => sliderValue switch
        {
            1 => 10000,
            2 => 50000,
            3 => 100000,
            4 => 500000,
            5 => 1000000,
            _ => 0
        };
    }
}
