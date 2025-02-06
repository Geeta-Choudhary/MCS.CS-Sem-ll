// const prompt = require("prompt -sync")();//import the prompt -sync package 


function swapCase(str) {
    return str 
    .split('')//convert string to array of characters
    .map(char => 
        char === char.toUpperCase() ? char.toLowerCase() : char.toUpperCase()
    )//Swap case
    .join('');//Convert  array back to  string 

}

//Example usage:
const inputString ="The Quick Brown Fox ,enters the house ";
const swappedString = swapCase(inputString);
console.log(swappedString);//output: tHE qUICK bROWN fOX , ENTERS THE HOUSE

/*
const inputString = prompt("Enter the string :");//taking the iput from the users
if (inputString !== null){
    const swappedString = swapCase(inputString);
    console.log(" After case swap :",swappedString);
}
*/