﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HimadriInfoSolution;

public class BasePage: ComponentBase
{
    [Inject]
    public required IJSRuntime JS { get; set; }

    public string Title { get; set; } = "Himadri Info Solution - ";

    protected override async Task OnInitializedAsync()
    {
        var DotNetHelper = DotNetObjectReference.Create(this);
        await JS.InvokeVoidAsync("SetDotnetReference", DotNetHelper);
    }
}
