function firstElements(array, n=1){
    //if input !=Array or input is empty return empty array[]
    if(!Array.isArray(array) || array.length === 0){
        return [];
    } 

    //if n==1 then return 1 st element of array, otherwise return the first n elements
    return n=== 1 ? array[0] :array.slice(0,n);
}

console.log(firstElements([10,20,30,40,50,60]));
console.log(firstElements([10,20,30,40,50,60],2));
console.log(firstElements([10,20,30,40,50,60],3));
console.log(firstElements([10,20,30,40,50,60],5));
console.log(firstElements([10,20,30,40,50,60],0));
console.log(firstElements([],2));
console.log(firstElements(["apple","mango","my favorite Lichi", "strawberry"],3));
console.log(firstElements("Hello,welcome to fruit mart ",2));