function solve(list){
    let username = list[0];
    let couter = 0;
    for (let index = 1; index < list.length; index++) {
        let element = list[index];
        if(element.split("").reverse().join("")===username){
        console.log(`User ${username} logged in.`)
        break;
    }
    else{
        couter++;
        if(couter===4){
            console.log(`User ${username} blocked!`)
            break;
        } 
        console.log(`Incorrect password. Try again.`);
    }
    }
}
solve(['Acer','login','go','let me in','recA'])
solve(['momo','omom'])
solve(['sunny','rainy','cloudy','sunny','not sunny'])