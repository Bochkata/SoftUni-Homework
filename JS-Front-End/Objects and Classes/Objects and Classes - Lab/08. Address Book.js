function solve(input){
    let output = {};
    for (let index of input) {
        let [name, address] = index.split(':');
        output[name] = address;
    }
    for (let key of Object.keys(output).sort()){
        console.log(`${key} -> ${output[key]}`)
    }
}
solve(['Tim:Doe Crossing','Bill:Nelson Place','Peter:Carlyle Ave','Bill:Ornery Rd'])