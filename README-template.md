# Frontend Mentor - Interactive pricing component solution

This is a solution to the [Interactive pricing component challenge on Frontend Mentor](https://www.frontendmentor.io/challenges/interactive-pricing-component-t0m8PIyY8). Frontend Mentor challenges help you improve your coding skills by building realistic projects.

## Table of contents

-   [Overview](#overview)
    -   [The challenge](#the-challenge)
    -   [Screenshot](#screenshot)
    -   [Links](#links)
-   [My process](#my-process)
    -   [Built with](#built-with)
    -   [What I learned](#what-i-learned)
    -   [Useful resources](#useful-resources)
-   [Author](#author)
-   [Acknowledgments](#acknowledgments)

## Overview

### The challenge

Users should be able to:

-   View the optimal layout for the app depending on their device's screen size
-   See hover states for all interactive elements on the page
-   Use the slider and toggle to see prices for different page view numbers

### Screenshot

![](./wwwroot/images/screenshot.jpg)

### Links

-   Solution URL: [https://github.com/marklnz/InteractivePricingComponent](https://github.com/marklnz/InteractivePricingComponent)
-   Live Site URL: [https://markl.nz/InteractivePricingComponent](https://markl.nz/InteractivePricingComponent)

## My process

### Built with

-   Semantic HTML5 markup
-   CSS custom properties
-   Flexbox
-   CSS Grid
-   Mobile-first workflow
-   [Blazor WASM](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) - Microsoft's SPA framework that allows compilation of C# code to Web Assembly

### What I learned

Another fun experiment to test my CSS knowledge. As with (my version of Frontend Mentor's Interactive Rating Card)[https://github.com/marklnz/BlazorRatingCard], I used no CSS frameworks, instead coding everything from scratch.

I also used [Blazor WASM](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) once again, with the aim being to write zero JavaScript. There was only one slightly challenging aspect to this, as most of the interactions were enabled via default browser behaviours when using HTML components, or CSS. This one spot was where the slider background fill is updated. I needed the track of slider (aka the `<input type="range">` HTEML element) to have a filled section behind the thumb, mirroring the way the default element works in most browsers. However when custom-styling this element with CSS there is no easy way to automate that. I relied on a technique whereby a background gradient is applied to the element, so I can specify the width of that image. I needed to be able to calculate the correct width percentage every time the slider is updated, and so I respond to that event using Blazor, updating a variable with the calculated width. I was not able to update the CSS directly, so rather than apply a different CSS Class depending on the width, I went with an inline style that does it.

### Useful resources

Once again I used MDN for a variety of things (i.e. _everything_), and this codepen helped immensely with custom styling of the `<input type="range">` element:

-   [Codepen - Range Input with values (Pure HTML, CSS, JS)](https://codepen.io/tippingpointdev/pen/bGgLqLY)

## Author

-   Website - [Mark Lawrence](https://markl.nz)
-   Frontend Mentor - [@marklnz](https://www.frontendmentor.io/profile/marklnz)

## Acknowledgments

Once again, thanks to Frontend Mentor, for publishing these challenges. It's a great resource both to challenge yourself, and to get inspiration from.
