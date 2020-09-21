using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlastUI.Components
{
    public partial class DesignSystemProvider
    {
        [Parameter] public bool UseDefaults { get; set; } = true;        
        [Parameter] public string AccentBaseColor { get; set; }
        [Parameter] public string BaseLayerLuminance { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
