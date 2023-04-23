function solve(name,lastname,haircolor){
    const Person = {name: name,lastName: lastname,hairColor: haircolor};
    console.log(JSON.stringify(Person));
}
solve('George', 'Jones', 'Brown');
solve('Peter', 'Smith', 'Blond');