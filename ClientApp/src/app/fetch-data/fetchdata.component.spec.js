"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var MockHttp = /** @class */ (function () {
    function MockHttp() {
    }
    MockHttp.prototype.get = function (url) {
        return {
            subscribe: function () { }
        };
    };
    return MockHttp;
}());
exports.MockHttp = MockHttp;
var mockHttp;
//This lets me run Angular in a small isolated environment for fast unit tests.
var fixture;
//Tells us if a function gets called during a test
//spyOn()
//Karma is a Test Runner
//Jasmine is a Test Library
//# sourceMappingURL=fetchdata.component.spec.js.map