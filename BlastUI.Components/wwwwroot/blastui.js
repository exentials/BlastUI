"use strict";
// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __makeTemplateObject = (this && this.__makeTemplateObject) || function (cooked, raw) {
    if (Object.defineProperty) { Object.defineProperty(cooked, "raw", { value: raw }); } else { cooked.raw = raw; }
    return cooked;
};
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.BlastDesignSystemProvider = void 0;
var fast_element_min_js_1 = require("./microsoft/fast-element/dist/fast-element.min.js");
var fast_components_min_js_1 = require("./microsoft/fast-components/dist/fast-components.min.js");
var fast_foundation_min_js_1 = require("./microsoft/fast-foundation/dist/fast-foundation.min.js");
var BlastDesignSystemProvider = /** @class */ (function (_super) {
    __extends(BlastDesignSystemProvider, _super);
    function BlastDesignSystemProvider() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    BlastDesignSystemProvider = __decorate([
        fast_foundation_min_js_1.designSystemProvider({
            name: "blast-design-system-provider",
            template: fast_foundation_min_js_1.DesignSystemProviderTemplate,
            styles: fast_element_min_js_1.css(templateObject_1 || (templateObject_1 = __makeTemplateObject([":host { display: block }"], [":host { display: block }"])))
        })
    ], BlastDesignSystemProvider);
    return BlastDesignSystemProvider;
}(fast_components_min_js_1.FASTDesignSystemProvider));
exports.BlastDesignSystemProvider = BlastDesignSystemProvider;
var templateObject_1;
//window.blastUI = {
//    getPalette: (color) => {
//        if (color) {
//            var palette = createColorPalette(color);
//            return [];
//        }
//    }
//}
//# sourceMappingURL=blastui.js.map