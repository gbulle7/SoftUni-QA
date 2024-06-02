let button = document.querySelector("#load");
let httpRequest;
button.addEventListener('click', eventListerFunction);

function eventListerFunction() {
    let url = 'https://api.github.com/users/gbulle7/repos';
    httpRequest = new XMLHttpRequest();
    httpRequest.addEventListener('readystatechange', httpAjaxHandler);
    httpRequest.open("GET", url);
    httpRequest.send();
}

function httpAjaxHandler() {
    if (httpRequest.readyState == 4 && httpRequest.status == 200) {
        document.getElementById('res').textContent = httpRequest.responseText;
    }
}

// function synchronousFunction() {
//     console.log('Hello');
//     setTimeout(function () {   // Asynchronous func
//         console.log('Goodbye!');        
//     }, 2000);
//     console.log('Hello again');
// }

// synchronousFunction();