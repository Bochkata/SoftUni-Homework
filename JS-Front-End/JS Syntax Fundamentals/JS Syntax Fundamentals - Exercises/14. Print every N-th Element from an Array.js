function solve(list,number){
    let output  = [];
    for (let i=0; i < list.length; i++) {
        if (i % number === 0) {
            output.push(list[i])
        }
    }
    return output 
}
solve(['dsa','asd', 'test', 'tset'], 2)