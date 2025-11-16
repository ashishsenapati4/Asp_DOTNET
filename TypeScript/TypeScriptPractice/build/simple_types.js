"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.hasAdminAccess = exports.randomValue2 = exports.randomValue = void 0;
let personName = "Ashish";
let age = 30;
let sentence = `My name is ${personName}. I am ${age} years old.`;
console.log(sentence);
// BigInt
const bigNumber = BigInt(9007199254741991);
const hugeNumber = 1234567890123456789012345678901234567890n;
console.log(`BigInt value: ${hugeNumber}`);
//Symbol
const sym1 = Symbol("description");
const sym2 = Symbol("description");
const obj = {
    [sym1]: "This is a unique key "
};
console.log(obj[sym1]);
console.log(sym1 === sym2); // false
//any
exports.randomValue = "This is first any type";
exports.randomValue2 = 900;
exports.hasAdminAccess = false;
console.log(`Random value:- ${exports.randomValue}, ${exports.randomValue2}, ${exports.hasAdminAccess}`);
