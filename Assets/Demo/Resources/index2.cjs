"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const csharp_1 = require("csharp");
const puerts_1 = require("puerts");
if (csharp_1.UnityEngine.Application.isEditor) {
    try {
        require("./debug/source-map-init");
    }
    catch (error) {
        console.warn("source-map is not working");
    }
}
console.log("index running");
let demoEntryObj = csharp_1.UnityEngine.GameObject.Find("DemoEntry");
let demoEntry = demoEntryObj.GetComponent((0, puerts_1.$typeof)(csharp_1.DemoEntry));
let testPrefab = demoEntry.testPrefab2;
setInterval(() => {
    csharp_1.UnityEngine.Object.Instantiate(testPrefab);
}, 1000);
//# sourceMappingURL=index2.cjs.map