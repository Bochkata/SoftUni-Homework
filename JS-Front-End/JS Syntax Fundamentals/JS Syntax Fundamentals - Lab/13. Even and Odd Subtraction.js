function solve(numbers){
    let evenSum = 0;
    let oddSum = 0;
    for (let index = 0; index < numbers.length; index++) {
        const element = numbers[index];
        if(element%2 ===0)
        evenSum+=element;
        else
        oddSum+=element;       
    }
    console.log(evenSum-oddSum);
}
solve([1,2,3,4,5,6])