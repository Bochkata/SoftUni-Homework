function solve(ordertype,quantity){
    if(ordertype==="coffee")
    console.log((1.50*quantity).toFixed(2))
    if(ordertype==="water")
    console.log((quantity).toFixed(2))
    if(ordertype==="coke")
    console.log((1.40*quantity).toFixed(2))
    if(ordertype==="snacks")
    console.log((2*quantity).toFixed(2))
}
solve("water", 5)