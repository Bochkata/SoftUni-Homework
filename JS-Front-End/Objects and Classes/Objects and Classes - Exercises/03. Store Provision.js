function solve(stock, ordered) {
    let output = {}
        for (i = 0; i < stock.length; i+=2){
            let [name, quantity] = [stock[i], stock[i+1]]
            if (name in output){
                output[name] += parseInt(quantity)
            } else {
                output[name] = parseInt(quantity)
            }
        }
        for (i = 0; i < ordered.length; i+=2){
            let [name, quantity] = [ordered[i], ordered[i+1]]
            if (name in output){
                output[name] += parseInt(quantity)
            } else {
                output[name] = parseInt(quantity)
            }
        }
    for (let [key, value] of Object.entries(output)) {
                console.log(`${key} -> ${value}`)
            }
}
solve(['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
    ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'])