function solve(list){
    let output = new Set();
    for (const current of list) {
        let[command,number] = current.split(`, `);
        if(command===`IN`)
        output.add(number);
        else if(command===`OUT`)
        output.delete(number);
    }
    if (output.size === 0) {
        console.log("Parking Lot is Empty")
      } else {
        console.log([...output].sort().join("\n"))
      }
}
solve(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']
)