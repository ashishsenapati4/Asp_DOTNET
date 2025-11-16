//Function with explicit types
function greet(name: string) : string{
    return `Hello, ${name}`;
}

const greeting: string = greet("Ashish"); //OK
console.log(greeting);

//greet(45); // Error: Argument of type 'number' is not assignable to parameter of type 'string'

//Object literal inference
const user = {
    name: "Alice",
    Age: 19,
    isAdmin: false
}

console.log(`User Name: ${user.name}, Age: ${user.Age}, Is Admin: ${user.isAdmin}`);
user.name = "Bob"; // OK
console.log(`Updated User Name: ${user.name}`);

//Explicit type mismatch
let height: number = 183;
//height = "183cm"; // Error: Type 'string' is not assignable to type 'number'

//Implicit type mismatch
let weight = 75; // Inferred as number
//weight = "75kg"; // Error: Type 'string' is not assignable to type 'number'


//While TypeScript's type inference is powerful, there are cases where it can't determine the correct type.

//In these situations, TypeScript falls back to the any type, which disables type checking.

const data: any = JSON.parse('{"name":"Alice", "age":30}')
console.log(typeof(data))
console.log(data.name);

let unknownVar
unknownVar = "Ashish"
unknownVar = 90;
console.log(typeof(unknownVar))