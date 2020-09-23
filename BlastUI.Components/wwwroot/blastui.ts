// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

import { css } from "./microsoft/fast-element/dist/fast-element.min.js";
import { createColorPalette, FASTDesignSystemProvider } from "./microsoft/fast-components/dist/fast-components.min.js";
import { designSystemProvider, DesignSystemProviderTemplate as template } from "./microsoft/fast-foundation/dist/fast-foundation.min.js";

@designSystemProvider({
    name: "blast-design-system-provider",
    template,
    styles: css`:host { display: block }`
})
export class BlastDesignSystemProvider extends FASTDesignSystemProvider {

}

//window.blastUI = {
//    getPalette: (color) => {
//        if (color) {

//            var palette = createColorPalette(color);
//            return [];
//        }
//    }
//}
