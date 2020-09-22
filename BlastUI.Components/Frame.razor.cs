using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlastUI.Components
{
    public partial class Frame
    {
        [Parameter] public string AccentColor { get; set; }
        [Parameter] public string BackgroundColor { get; set; }
        [Parameter] public bool? DarkMode { get; set; }
        [Parameter] public int? BaseLayerLuminance { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
