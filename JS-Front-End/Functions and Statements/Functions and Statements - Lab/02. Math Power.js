function solve(num,power){
    let result = 1;
    for (let index = 0; index < power; index++) {
        result *=num;
    }
    console.log(result);
}
solve(2,8)