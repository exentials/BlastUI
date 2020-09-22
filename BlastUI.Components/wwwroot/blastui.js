// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

import { createColorPalette } from "./microsoft/fast-components/dist/fast-components.min.js";

export class BlastUI {

    createPalette(baseColor) {
        return createColorPalette(baseColor);
    }
}

window.blastUI = {
    getPalette: (color) => {
        if (color) {
            var bui = new BlastUI();
            var palette = bui.createPalette(color);
            // var palette = createColorPalette(color);
            return palette;
        }
    }
}
