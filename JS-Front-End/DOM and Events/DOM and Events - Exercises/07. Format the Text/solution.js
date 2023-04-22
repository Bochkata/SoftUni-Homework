function solve() {
  let text = document.getElementById("input").value.split(".").filter(e => e.length > 0)
  let div = document.getElementById("output");
  for (i = 0; i < text.length; i += 3) {
    let output = [];
    for (j = 0; j < 3; j++) {
      if (text[i + j]) {
        output.push(text[i + j])
      }
    }
    let res = output.join(". ") + "."
    div.innerHTML += `<p>${res}</p>`
  }

}