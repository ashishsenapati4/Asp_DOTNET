function greet(name: string): string {
    return `Hello, ${name}!`;
}

const message: string= greet("Ashish")
console.log(message);

import { randomValue2 } from "./new";
console.log(`Random value from simple_types: ${randomValue2}`);

import {add}from "./new"
const additionResult: number = add(5, 10);
console.log(`Addition Result: ${additionResult}`);