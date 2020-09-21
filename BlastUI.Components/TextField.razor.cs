using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public partial class TextField: InputText
    {
        [Parameter] public string FiledType { get; set; }
        [Parameter] public string Name { get; set; }

        [Parameter] public string Caption { get; set; }
        [Parameter] public string Appearence { get; set; }
        [Parameter] public string Placeholder { get; set; }

        [Parameter] public int? MinLength { get; set; }
        [Parameter] public int? MaxLength { get; set; }

        [Parameter] public bool? Autofocus { get; set; }
        [Parameter] public bool? ReadOnly { get; set; }
        [Parameter] public bool? Disabled { get; set; }
    }
}
