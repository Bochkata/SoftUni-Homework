function solve(day,age){
    if(age<0)
    {
       return console.log(`Error!`);  
       
    }
 
    if(day==="Weekday")
    {
        if(age<=18 )    
         console.log(`12$`);
        else if(age<=64)    
         console.log(`18$`);
        else if(age<=122)    
         console.log(`12$`);
         else
         console.log(`Error!`);       
    }
    if(day==="Weekend")
    {
        if(age<=18 )    
         console.log(`15$`);
        else if(age<=64)    
         console.log(`20$`);
        else if(age<=122)    
         console.log(`15$`);
         else
         console.log(`Error!`);       
    }
    if(day==="Holiday")
    {
        if(age<=18 )    
         console.log(`5$`);
        else if(age<=64)    
         console.log(`12$`);
        else if(age<=122)    
         console.log(`10$`);
         else
         console.log(`Error!`);       
    }
}
solve('Weekday', 42)