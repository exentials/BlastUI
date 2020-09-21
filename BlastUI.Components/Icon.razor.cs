using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlastUI.Components
{
    public partial class Icon : ComponentBase
    {
        [Parameter] public string Name { get; set; }
        [Parameter] public string CssClass { get; set; }
    }
}
