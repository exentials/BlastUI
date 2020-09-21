using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlastUI.Components
{
    public partial class Card : ComponentBase
    {
        [Parameter] public int? Width { get; set; }
        [Parameter] public int? Height { get; set; }
        [Parameter] public int? Elevation { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        private string Styles
        {
            get
            {
                Dictionary<string, object> style = new Dictionary<string, object>();
                if (Width.HasValue) { style.Add("width", Width.Value); }
                if (Height.HasValue) { style.Add("height", Width.Value); }
                if (Elevation.HasValue) { style.Add("elevation", Width.Value); }
                var styles = String.Join(' ', style.Select(s => $"{s.Key}: {s.Value};").ToArray());
                return styles;
            }
        }
    }
}
