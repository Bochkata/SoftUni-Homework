function colorize() {
    let table = document.getElementsByTagName("tr");
    for (let i = 1; i < 4; i=i+2) {
        table[i].style.background = "teal";
    }

}