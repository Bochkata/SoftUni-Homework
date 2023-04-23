function solve(count,helmetPrice,swordPrice,shieldPrice,armorPrice){
    let result = 0;
    result+=Math.floor(count/2)*helmetPrice;
    result+=Math.floor(count/3)*swordPrice;
    result+=Math.floor(count/6)*shieldPrice;
    result+=Math.floor(count/12)*armorPrice;
    console.log(`Gladiator expenses: ${result.toFixed(2)} aureus`)
}
solve(7,2,3,4,5)
solve(23,12.50,21.50,40,200)