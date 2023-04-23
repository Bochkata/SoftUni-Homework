function solve(num1,num2){
    let result1 = 1;
    let result2 = 1;
    for (let index = 1; index <= num1; index++) {
    result1*=index; 
    }
    for (let index = 1; index <= num2; index++) {
        result2*=index; 
        }
    console.log((result1/result2).toFixed(2));
}
solve(6,2)