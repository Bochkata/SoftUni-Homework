function solve(input){
    let output={};
    for (let item of input) {
        let[name,phoneNum] = item.split(" ");
        output[name] = phoneNum;
    }
    for (let [key,value] of Object.entries(output)) {
        console.log(`${key} -> ${value}`)
    }
}
solve(['Tim 0834212554','Peter 0877547887','Bill 0896543112','Tim 0876566344'])
solve(['George 0552554','Peter 087587','George 0453112','Bill 0845344'])