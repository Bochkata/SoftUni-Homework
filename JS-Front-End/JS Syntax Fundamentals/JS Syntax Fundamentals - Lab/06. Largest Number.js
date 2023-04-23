function solve(num1,num2,num3){
    if(num1>num2 && num1>num3)
    console.log(`The largest number is ${num1}.`)
    if(num2>num1 && num2>num3)
    console.log(`The largest number is ${num2}.`)
    if(num3>num2 && num3>num1)
    console.log(`The largest number is ${num3}.`)
}
solve(10,20,30)