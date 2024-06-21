function promiseWithMultipleHandlers() {
    let promise = new Promise(function(resolve, reject) {
        setTimeout(() => {
            resolve("Hello World");
        }, 2000);
    })
    .then(function(result) {
        console.log(result);
        return result;
    })
    .then(function(result) {
        console.log(result);
    })
}


// function promiseWithMultipleHandlers() {
//     new Promise((resolve) => {
//             setTimeout(() => resolve("Hello World"), 2000);
//         })
//         .then((message) => {
//             console.log(message); 
//             return message; 
//         })
//         .then((message) => {
//             console.log(message); 
//         });
// }