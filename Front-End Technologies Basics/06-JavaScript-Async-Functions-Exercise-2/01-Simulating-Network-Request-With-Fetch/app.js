async function fetchData() {
    const response = await fetch('https://swapi.dev/api/people/1');
    const data = await response.json();
    console.log(data);
}

// function fetchData() {
//     const response = fetch('https://swapi.dev/api/people/1');
//     response.then(function(resolve, reject){
//         return resolve.json();
//     })
//     .then(function(resolve, reject) {
//         console.log(resolve);
//     }
// )
// }

// function fetchData() {
//     fetch('https://swapi.dev/api/people/1')
//     .then(response => response.json())
//     .then(data => console.log(data));
// }