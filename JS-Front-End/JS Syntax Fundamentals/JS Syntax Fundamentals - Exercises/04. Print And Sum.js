function solve(start,end){
    let result =0;
    let resultNums ="";
    for (let index = start; index <= end; index++) {
resultNums+= index + " "; 
       result+=index;
    }
    console.log(resultNums);
    console.log(`Sum: ${result}`);
}
solve(5, 10)