let personName: string = "Ashish";
let age: number = 30;
let sentence: string = `My name is ${personName}. I am ${age} years old.`;

console.log(sentence);

// BigInt
const bigNumber: bigint = BigInt(9007199254741991);

const hugeNumber: bigint = 1234567890123456789012345678901234567890n;

console.log(`BigInt value: ${hugeNumber}`);

//Symbol
const sym1: symbol = Symbol("description");
const sym2: symbol = Symbol("description");

const obj = {
    [sym1]: "This is a unique key "
}
console.log(obj[sym1])
console.log(sym1 === sym2); // false

//any
export const randomValue: any = "This is first any type"
export const randomValue2: any = 900
export const hasAdminAccess: any = false
console.log(`Random value:- ${randomValue}, ${randomValue2}, ${hasAdminAccess}`)
