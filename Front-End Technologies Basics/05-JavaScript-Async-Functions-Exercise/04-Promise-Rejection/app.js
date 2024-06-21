function promiseRejection() {
    let promise = new Promise(function(resolve, reject) {
        setTimeout(function() {
            reject("Something went wrong!");
        }, 1000);
    });
    promise.catch(function(err) {
        console.log(err);
    });
}

// function promiseRejection() {
//     new Promise((_, reject) => {
//         setTimeout(() => reject(new Error("Something went wrong!")), 1000);
//     }).catch(console.error);
// }