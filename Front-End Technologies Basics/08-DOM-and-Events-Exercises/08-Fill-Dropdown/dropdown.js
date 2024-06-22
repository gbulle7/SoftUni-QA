function addItem() {
    let textItem = document.getElementById("newItemText");
    let valueItem = document.getElementById("newItemValue");
    let selectItem = document.getElementById("menu");

    let optionElement = document.createElement("option");
    optionElement.textContent = textItem.value;
    optionElement.value = valueItem.value;

    selectItem.appendChild(optionElement)
    textItem.value = "";
    valueItem.value = "";
}


// function addItem() {
//     let inputTextElement = document.querySelector('#newItemText');
//     let inputValueElement = document.querySelector('#newItemValue');

//     let menu = document.querySelector('#menu');
//     let option = document.createElement('option');

//     option.textContent = inputTextElement.value;
//     option.value = inputValueElement.value;
//     menu.appendChild(option);

//     inputValueElement.value = '';
//     inputTextElement.value = '';
// }