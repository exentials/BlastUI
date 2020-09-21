using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlastUI.Components
{
    public partial class Badge
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
