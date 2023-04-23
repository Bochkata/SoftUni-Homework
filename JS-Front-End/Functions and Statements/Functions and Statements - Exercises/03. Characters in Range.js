function solve(input1,input2)
{
    let char1 = input1.charCodeAt(0);
    let char2 = input2.charCodeAt(0); 
    let result = "";

    if(char2>char1)
    {
        for (let index = char1+1; index < char2; index++) 
        {
            result+= String.fromCharCode(index)+" ";        
        }   
    }
    else
    {
        for (let index = char2+1; index < char1; index++) 
        {
            result+= String.fromCharCode(index)+" ";        
        }   
    }
    console.log(result);
}
solve('C',
'#'
)