function solve(list){
    let result = {};
    for (let i = 0; i < list.length; i++) {
        let [key, value] = list[i].split(' : ');
        result[key] = key.length;
    }
    for (let [key,value] of Object.entries(result)) {
        console.log(`Name: ${key} -- Personal Number: ${value}`);
    }
}
solve(['Silas Butler','Adnaan Buckley','Juan Peterson','Brendan Villarreal'])
solve(['Samuel Jackson','Will Smith','Bruce Willis','Tom Holland'])