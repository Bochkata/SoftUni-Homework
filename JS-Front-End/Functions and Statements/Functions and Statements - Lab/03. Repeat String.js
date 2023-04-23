function solve(string,power){
    let result = "";
    for (let index = 0; index < power; index++) {
        result +=string;
    }
    console.log(result);
}
solve("abc", 3)