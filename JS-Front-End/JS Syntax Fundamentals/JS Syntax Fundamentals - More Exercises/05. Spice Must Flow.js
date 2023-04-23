function solve(quantity){
    let days = 0;
    let result = 0;
    while(quantity>=100){
        days++;
        result+=quantity-26;
        quantity-=10;
    }
    if (result >=26) {
        result -= 26;
    } 
    else
    result = 0

    console.log(days);
    console.log(result);
}
solve(111)
solve(450)