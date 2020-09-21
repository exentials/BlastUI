using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class Accordion : ComponentBase
    {
        private List<AccordionItem> accordionItems = new List<AccordionItem>();
        private AccordionExpandMode? _expandMode;

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public AccordionExpandMode ExpandMode { 
            get { return _expandMode ?? AccordionExpandMode.Multi; }
            set { _expandMode = (value == AccordionExpandMode.Multi) ? (AccordionExpandMode?)null : value; }
        } 

        internal void Register(AccordionItem item)
        {
            accordionItems.Add(item);
        }

        internal async Task NotifyChangeAsync(AccordionItem changedItem)
        {
            if (ExpandMode == AccordionExpandMode.Single)
            {
                foreach (var accordionItem in accordionItems.Where(item => item.Expanded))
                {
                    await accordionItem.Collapse();
                }
            } else
            {
                await InvokeAsync(StateHasChanged);
            }
        }
    }
}
