using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class DesignSystemProvider
    {
        [Inject] private IJSRuntime JSRuntime { get; set; }

        [Parameter] public bool UseDefaults { get; set; } = true;
        [Parameter] public string AccentBaseColor { get; set; }
        [Parameter] public string BaseLayerLuminance { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        private ElementReference fastDesignSystemProvider;

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (!string.IsNullOrEmpty(AccentBaseColor))
                {
                    // var accentPalette = await JSRuntime.InvokeAsync<object>("blastUI.getPalette", AccentBaseColor);
                }
            }
            return base.OnAfterRenderAsync(firstRender);
        }
    }

}
