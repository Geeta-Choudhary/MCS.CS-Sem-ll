function findPairWithSum(arr , target){
    let numIndices = new Map();//store the numbers and their indices

    for(let i =0 ; i<arr.length ; i++){
        let complement = target-arr[i];//find the number needed to reach the target
        
        if(numIndices.has(complement)){
            return [numIndices.get(complement),i];//Return the indices of the pair

        }
        numIndices.set(arr[i],i);//Store the number and its index
    }
    return null;//if no pair found
}

//Example Usage
const numbers =[20,60,10,10,80,50,60,70,30];
const target = 50;

const result = findPairWithSum(numbers,target);
if(result){
    console.log(`Output: ${result[0]}, ${result[1]}`);
}else{
    console.log("No pair found .");
}