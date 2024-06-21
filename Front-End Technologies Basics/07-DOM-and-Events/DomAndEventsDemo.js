//creating new div element
document.title = "New Title"; // Задава заглавието на документа
let newDiv = document.createElement("div"); // Създава нов елемент div
newDiv.innerHTML = "Hello!";
document.body.appendChild(newDiv); // Добавя новия div към тялото на документа

//adding event listener to a button
document.getElementById("button").addEventListener("click", function () {
    alert("Button pressed!");
});

//manipulating inner html
let div = document.getElementById("divTest");
console.log(div.innerHTML);
div.innerHTML = "<p>New content</p>";

//manipulating textContent
let paragraph = document.getElementById("pTest");
console.log(paragraph.textContent);
paragraph.textContent = "New content";

//manipulating style
let button = document.getElementById("button");
button.style.color = "blue"
console.log(button.style.color.toString())


//manipulating value
let input = document.querySelector("input");
input.value = "New value";

//manipulating id
let element = document.getElementById("input");
element.id = "newId";


//showing alert 
function showAlert() {
    alert("Question?")
}
//<button id="button" onclick="alert('Question')">Button</button>


//setting color and fint size
let element = document.getElementById("example");
element.style.color = "blue"; // Задава нов цвят на текста
element.style.fontSize = "20px"; // Задава нов размер на шрифта

//iterating nodeList
let nodesNL = document.querySelectorAll("div, p, span, a");
console.log(nodes)
nodes.forEach(node => {
    console.log(node.textContent);
});

//accessing elements by index
let nodes = document.querySelectorAll("p");
console.log(nodes[0])

//iterating with for loop
let nodesFL = document.querySelectorAll("p");
//console.log(nodes[0]);
for (let n of nodes) {
    // Изпълнява код за всеки <p> елемент
    console.log(n.textContent);
}

//converting to array
let nodesA = document.querySelectorAll("div, p, span, a");

const elementArray = Array.from(nodes);
console.log(elementArray.length)

//accessing parent element
let firstP = document.getElementsByTagName('p')[0];
console.log(firstP.parentElement);

//accessing children element
let children = document.getElementById('example').children;
console.log(children);


//live collection example
let div = document.getElementById('example');
let children1 = div.children;
console.log(children1.length);

let newAnchor = document.createElement('a');
div.appendChild(newAnchor);
console.log(children1.length); // Ще покаже 3, защото колекцията е жива


//making element invisible
let div = document.getElementById("example");
div.style.display = 'none';


//matching nth child with css
const thirdLi = document.querySelector('ul li:nth-child(3)');
console.log(thirdLi)


//replace element
const parentElement = document.getElementById('example'); 
const oldChildElement = document.getElementById('example1'); 
const newChildElement = document.createElement('p');
newChildElement.textContent = 'This is a new paragraph.';
parentElement.replaceChild(newChildElement, oldChildElement);


//creating element
const element = document.createElement('p');
element.textContent = 'Initial text';
document.body.appendChild(element);
element.textContent = 'Updated text';
console.log(element.textContent)
const div = document.getElementById("example");
div.appendChild(element)


//deleting elements
const childElement = document.querySelectorAll("li")[1];

childElement.parentNode.removeChild(childElement);


//eventListeners event object
let button = document.getElementById("button");
button.addEventListener('click', function(event) {
    console.log(event);
  });


//accessing screenX and screenY from event object
let button = document.getElementById("button");
button.addEventListener('click', function(event) {
    console.log(`Screen coordinates: (${event.screenX}, ${event.screenY})`);
  });


//attaching multiple eventListeners to same element
let element = document.getElementById('child');
element.addEventListener('mouseover', function(event) {
    this.style.background = 'blue';
});

element.addEventListener('mouseout', function(event) {
    this.style.background = 'red';
});

//removing event listener from element after 5 secs timeout
const button = document.getElementsByTagName('button')[0];

button.addEventListener('click', handleClick);

function handleClick() {
    alert('Button clicked!');
}

setTimeout(function() {
    button.removeEventListener('click', handleClick);
    alert('Event listener removed!');
}, 5000);
