function isArray(input){
    return Array.isArray(input);
}

//Example usage:
/*
console.log(isArray([1,2,3]));//true
console.log(isArray("hello"));//false
console.log(isArray({name :"siya"}));//false
console.log(isArray(123));//false
console.log(isArray([]));//true
*/
const testInputs =[
    [1,2,3],
    "Hello",
    {a:1},
    123,
    true,
    null,
    undefined,function(){},new Set([1,2,3]),[]

];

testInputs.forEach((input, index) => {
    console.log(`Input  ${index + 1}:`,input," -> IS array ?" ,isArray(input));
});