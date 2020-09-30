using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlastUI.Components
{
    partial class Checkbox
    {
        bool? _checked;

        [Parameter]
        public bool Checked
        {
            get
            { 
                return _checked ?? false; 
            }
            set
            {
                _checked = value ? true : (bool?)null;
            }
        }
        [Parameter] public bool? Autofocus { get; set; }
        [Parameter] public bool? Disabled { get; set; }
        [Parameter] public bool? ReadOnly { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        
    }
}
