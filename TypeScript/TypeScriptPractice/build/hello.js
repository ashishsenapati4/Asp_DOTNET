"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function greet(name) {
    return `Hello, ${name}!`;
}
const message = greet("Ashish");
console.log(message);
const new_1 = require("./new");
console.log(`Random value from simple_types: ${new_1.randomValue2}`);
const new_2 = require("./new");
const additionResult = (0, new_2.add)(5, 10);
console.log(`Addition Result: ${additionResult}`);
