function solve(num){
    if(num===100)
    {
        console.log(`100% Complete!`)
        console.log(`[%%%%%%%%%%]`)
    }
    else
    {
        let result ="";
        for (let index = 0; index < num/10; index++) {
            result+=`%`;
        }
        for (let index = num/10; index < 10; index++) {
            result+=`.`;  
        }
        console.log(`${num}% [${result}]`);
        console.log(`Still loading...`);
    }
}
solve(30)