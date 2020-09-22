// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

import { createColorPalette } from "./microsoft/fast-components/dist/fast-components.min.js";


window.blastUI = {
    getPalette: (color) => {
        if (color) {

            var palette = createColorPalette(color);
            return [];
        }
    }
}
