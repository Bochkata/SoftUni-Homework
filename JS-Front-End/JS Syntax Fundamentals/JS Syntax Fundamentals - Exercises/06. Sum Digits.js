function solve(num){
    let sum = 0;
    const length = num.toString().length;
    for (let index = 0; index < length; index++) {
        sum += num % 10;
        num = Math.floor(num / 10);
    }
    console.log(sum)
}
solve(245678)