function allPromise() {
    let promise1 = new Promise(function(resolve, reject) {
        setTimeout(function() {
            resolve("Resolve1");
        }, 1000);
    });

    let promise2 = new Promise(function(resolve, reject) {
        setTimeout(function() {
            resolve("Resolve2");
        }, 2000);
    });

    let promise3 = new Promise(function(resolve, reject) {
        setTimeout(function() {
            resolve("Resolve3");
        }, 3000);
    });

    Promise.all([promise1, promise2, promise3])
    .then(function(result) {
        console.log(result);
    })
}


// function allPromise() {
//     const p1 = new Promise(resolve => setTimeout(() => resolve("1 second"), 1000));
//     const p2 = new Promise(resolve => setTimeout(() => resolve("2 seconds"), 2000));
//     const p3 = new Promise(resolve => setTimeout(() => resolve("3 seconds"), 3000));
    
//     Promise.all([p1, p2, p3]).then(console.log);
// }