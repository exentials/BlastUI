using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class Switch : InputCheckbox
    {
        [Parameter] public string Caption { get; set; }
        [Parameter] public string CheckedMessage { get; set; }
        [Parameter] public string UncheckedMessage { get; set; }

        [Parameter] public bool? Disabled { get; set; }
        [Parameter] public bool? ReadOnly { get; set; }

        private async Task Toggle(MouseEventArgs args)
        {
            if (!((ReadOnly ?? false) || (Disabled ?? false)))
            {
                this.Value = !Value;
                await ValueChanged.InvokeAsync(this.Value);
            }
        }
    }
}
