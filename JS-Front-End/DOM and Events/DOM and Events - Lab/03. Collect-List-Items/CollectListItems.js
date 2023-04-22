function extractText() {
    const item1 = document.getElementsByTagName('li');
    console.log(item1);
    let area = document.querySelector("#result");
    for(let element of item1) {
        area.value += element.textContent + "\n";
}
    
}