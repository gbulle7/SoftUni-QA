// Get request
fetch('https://api.github.com/users/gbulle7/repos')
.then((response) => response.json())
.then((data) => console.log(data))
.catch((error) => console.error(error))

// Post request
// fetch('/url', {
//     method: 'post',
//     headers: {'Content-type': 'application/json'},
//     body: JSON.stringify(data),
// })


// .clone() the response
// fetch('https://api.github.com/users/gbulle7/repos')
//     .then(function(response) {
//         let clonedResponse = response.clone();
//         response.json();
//         console.log(clonedResponse);
//     }) 
//     .then((data) => console.log(data))
//     .catch((error) => console.error(error));


// .text()
// fetch('https://api.github.com/users/gbulle7/repos')
//     .then(function(response) {
//         return response.text();
//     })
//     .then((data) => console.log(data))
//     .catch((error) => console.error(error))