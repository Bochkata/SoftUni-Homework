function solve(year){
    if ((0 == year % 4) && (0 != year % 100) || (0 == year % 400)) {
        console.log('yes');
    } else {
        console.log('no');
    }
}
solve(1984)
solve(1900)