function solve(Number1,operator,Number2){
    if(operator==="+")
    console.log((Number1+Number2).toFixed(2));
    if(operator==="-")
    console.log((Number1-Number2).toFixed(2));
    if(operator==="*")
    console.log((Number1*Number2).toFixed(2));
    if(operator==="/")
    console.log((Number1/Number2).toFixed(2));
}
solve(5,'+',10)