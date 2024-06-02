// For example, promise fails if parameter = 3 else success
// let a = 3;
let a = 4;
console.log('Before promise');
new Promise(function(resolve, reject) {
    setTimeout(function() {
        resolve('done');
    }, 500);
    if (a==3) {
        reject(`value is ${a}`)
    };
})
.then(function(res) {
    console.log('Then returned: ' + res);
})
.catch(function(res) {
    console.log('Failed ' + res);
});
console.log('After promise');


// another promise
console.log('before promise2');
let promise2 = new Promise(function(res, rej) {
    let success = false;
    if (success) {res("Operation successful!");}
    else {rej("Operation is NOT successful!");}
});

promise2.then((result) => {
    console.log(result);
})
.catch((err) => {
    console.log(err);
});
console.log('after promise2');


// using .resolve .reject methods
function validateInput(input) {
    if (input !== 'expectedValue') {
        return Promise.reject('Invalid input');
    }
    return Promise.resolve('Valid input');
};
validateInput('expectedValue')
.then(result => {console.log(result);})
.catch(err => {console.log(err);});


// multiple promises chaining using .all method (fulfills when all promises fulfill; rejects even if only one of them rejects)
function fetchData1() {
    return new Promise(resolve => {
        setTimeout(() => resolve("Data from API 1"), 1000);
    })
}

function fetchData2() {
    if (2 > 1) {    // fails if 2 < 1
        return Promise.resolve('Valid input');
    }
    return Promise.reject('Invalid input');
};

function fetchData3() {
    return new Promise(resolve => {
        setTimeout(() => resolve("Data from API 3"), 1500);
    })
}

Promise.all([fetchData1(), fetchData2(), fetchData3()])
.then(result => {
    console.log(result);
})

// .allSettled to return resolved and rejected (all fulfilled) promises, so 1<2 won't fail the others
Promise.allSettled([fetchData1(), fetchData2(), fetchData3()])
.then(result => {
    console.log(result);
})

// .race returns the first fulfilled promise (resolved or rejected)
Promise.race([fetchData1(), fetchData2(), fetchData3()])
.then(result => {
    console.log(result);
})

// Promise.prototype.finally
