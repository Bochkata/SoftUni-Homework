function solve(input){
    let number = parseInt(input);
    let length = number.toString().length;

    let oddSum = 0;
    let evenSum = 0;

    for (let index = 0; index < length; index++) 
    {
        let cur = number%10;
        number = parseInt(number/10);
        if(cur%2===0)
        evenSum+=cur;
        else
        oddSum+=cur;
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}
solve(1000435)