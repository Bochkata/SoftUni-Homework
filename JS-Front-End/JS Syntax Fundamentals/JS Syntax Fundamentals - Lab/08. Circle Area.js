function solve(num){
    let type = typeof(num);
    if(type === 'number')
    {
        let result =  Math.pow(num,2) *Math.PI;
        console.log(result.toFixed(2));
    }
    else
    console.log(`We can not calculate the circle area, because we receive a ${type}.`)
}
solve(5)