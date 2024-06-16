function simplePromise() {
    let promise = new Promise(function(resolve, reject) {
        setTimeout(function() {
            resolve("Success!");
        }, 2000);
    });
    promise.then(function(result) {
        console.log(result);
    });
}

// function simplePromise() {
//     let promise = new Promise(function(resolve, reject) {
//         setTimeout(function() {
//             resolve("Success!");
//         }, 2000);
//     })
//     .then(function(result) {
//         console.log(result);
//     });
// }

// function simplePromise() {
//     new Promise((resolve) => {
//         setTimeout(() => resolve("Success!"), 2000);
//     }).then(console.log);
// }