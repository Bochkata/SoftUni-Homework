function solve(string,word){
    let words = string.split(' ');
    let counter =0;
    for(let cur of words){
        if(cur===word)
        counter++;
    }
    console.log(counter);
}
solve('This is a word and it also is a sentence','is')