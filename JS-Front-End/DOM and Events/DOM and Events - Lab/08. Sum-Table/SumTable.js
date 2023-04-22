function sumTable() {
    let table = document.getElementsByTagName("tr");
    console.log(table);
    let sum = 0;
    for (let i = 1; i < 4; i=i+1) {
        let number = table[i].children[1].textContent;
        sum += Number(number);    
    }
    let result = document.getElementById("sum");
    result.textContent = sum;
}