function solve (name,lastName,age){
    const Person = {firstName: name,lastName: lastName,age: age};
    return Person;
}
console.log(solve("Peter", "Pan","20"));