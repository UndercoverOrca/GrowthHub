using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GrowthHub.WebUi.Components.Pages;

public abstract class BasePageComponent : ComponentBase
{
    [Inject]
    protected IJSRuntime JSRuntime { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender)
        {
            // await JSRuntime.InvokeVoidAsync();
        }
    }
}