using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class ButtonLink : ComponentBase
    {
        // https://github.com/microsoft/fast/blob/master/packages/web-components/fast-foundation/src/button/button.spec.md
        [Parameter] public bool? Autofocus { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public bool? Disabled { get; set; }

        [Parameter] public string Appearance { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> Click { get; set; }

        [Parameter] public RenderFragment Start { get; set; }
        [Parameter] public RenderFragment End { get; set; }

    }
}
