function addItem() {
    const item = document.getElementById('newItemText').value;
    if(item!==""){
        const newitem = document.createElement("li");
        newitem.textContent = item;
        document.getElementById("items").appendChild(newitem);
        document.getElementById("newItemText").value = "";
    }
}
