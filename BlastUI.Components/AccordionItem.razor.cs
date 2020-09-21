using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class AccordionItem: ComponentBase
    {
        [CascadingParameter] Accordion Accordion { get; set; }

        /// <summary>
        /// Configures the level of the heading element
        /// </summary>
        [Parameter] public HeadingLevelType? HeadingLevel { get; set; }
        [Parameter] public bool Expanded { get; set; }
        [Parameter] public string Id { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public RenderFragment Heading { get; set; }
        [Parameter] public RenderFragment Start { get; set; }
        [Parameter] public RenderFragment End { get; set; }
        [Parameter] public RenderFragment ExpandIcon { get; set; }
        [Parameter] public RenderFragment CollapseIcon { get; set; }


        override protected void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Accordion.Register(this);
            }
        }

        internal async Task Collapse()
        {
            Expanded = false;
            await InvokeAsync(StateHasChanged);
        }

        internal async Task Toggle()
        {
            Expanded = !Expanded;
            await Accordion.NotifyChangeAsync(this);
        }
    }
}
