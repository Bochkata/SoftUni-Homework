function solve(fruit,kg,price){
    console.log(`I need $${(price*kg/1000).toFixed(2)} to buy ${(kg/1000).toFixed(2)} kilograms ${fruit}.`)
}
solve('orange', 2500, 1.80)