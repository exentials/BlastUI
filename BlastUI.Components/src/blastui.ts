import { css } from "@microsoft/fast-element";
import { createColorPalette, FASTDesignSystemProvider } from "@microsoft/fast-components";
import { designSystemProvider, DesignSystemProviderTemplate as template } from "@microsoft/fast-foundation";
import { parseColor } from "@microsoft/fast-colors";

@designSystemProvider({
    name: "blast-design-system-provider",
    template,
    styles: css`:host { display: block }`
})
export class BlastDesignSystemProvider extends FASTDesignSystemProvider {

    accentBaseColorChanged(oldValue: string, newValue: string) {
        if (newValue !== oldValue) {
            this.accentBaseColor = newValue;
            const parsedColor = parseColor(newValue)
            if (parsedColor) {
                this.accentPalette = createColorPalette(parsedColor);
            }
        }
    }

    backgoundColorChanged(oldValue: string, newValue: string) {
        if (newValue !== oldValue) {
            this.backgroundColor = newValue;
            const parsedColor = parseColor(newValue)
            if (parsedColor) {
                this.neutralPalette = createColorPalette(parsedColor);
            }
        }
    }

}
