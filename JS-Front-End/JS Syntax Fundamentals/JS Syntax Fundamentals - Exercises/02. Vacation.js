function solve(number,type,day){
    let price = 0;

    if(type==="Students")
    {
        if(day==="Sunday")
        price = 10.46 * number;
        if(day==="Saturday")
        price = 9.80 * number;
        if(day==="Friday")
        price = 8.45* number;
        if(number>=30)
        price = price * 17 /20 ;
        console.log(`Total price: ${price.toFixed(2)}`);
    }
    if(type==="Business")
    {
        if(number>=100)
        number-=10;
        if(day==="Sunday")
        price = 16 * number;
        if(day==="Saturday")
        price =15.60 * number;
        if(day==="Friday")
        price = 10.90* number;
        console.log(`Total price: ${price.toFixed(2)}`);
    }
    if(type==="Regular")
    {
        if(day==="Sunday")
        price = 22.50 * number;
        if(day==="Saturday")
        price = 20	 * number;
        if(day==="Friday")
        price = 15 * number;
        if(number>=10 && number<=20)
        {
            price = price * 19 /20;
        }
        console.log(`Total price: ${price.toFixed(2)}`);
    }
}
solve(30,
    "Students",
    "Sunday"
    )