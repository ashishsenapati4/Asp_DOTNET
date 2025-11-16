//without 'any'
let u = true;
// u = 90    //error TS2322: Type 'number' is not assignable to type 'boolean'.
// Math.round(u) //error TS2345: Argument of type 'boolean' is not assignable to parameter of type 'number'.
//with 'any' no error
let isTrue = true;
isTrue = "Ahso";
console.log(Math.round(isTrue)); //NaN
//Type : unknown
//The unknown type is a type-safe counterpart of any
let w = 1;
console.log(w);
w = "string";
console.log(w);
w = {
    runANonExistentMethod: () => {
        console.log("Non-existent method running");
    }
};
// w.runANonExistentMethod();
console.log(w);
if (typeof w === 'object' && w !== null) {
    w.runANonExistentMethod();
    // w.runANonExistentMethod();
}
const w1 = {
    runANonExistentMethod: () => console.log("I think therefore I am")
};
w1.runANonExistentMethod(); // ✅ Works, TypeScript knows the type
let var1 = "AString";
function ProcessValue(variable) {
    if (typeof variable === 'string') {
        console.log(`Variable ${variable} is a string`);
    }
    else if (typeof variable === 'number') {
        console.log(`Variable ${variable} is a number`);
    }
    else {
        console.log("type unknown");
    }
}
ProcessValue(var1);
function area(shape) {
    switch (shape.kind) {
        case 'circle':
            return Math.PI * shape.radius ** 2;
        case 'square':
            return shape.side ** 2;
            ;
        default:
        // Exhaustive check
        // const _exhaustiveCheck: never = shape;
        // return _exhaustiveCheck;
    }
}
const myCircle = { kind: 'circle', radius: 5 };
console.log(area(myCircle));
const mySquare = { kind: 'square', side: 8 };
console.log(area(mySquare));
let y = null;
console.log(typeof y);
let z = undefined;
console.log(typeof z);
