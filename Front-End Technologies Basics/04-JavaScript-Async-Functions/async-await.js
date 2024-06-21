function resolveAfter2Seconds() {
    console.log('calling');
    return new Promise(resolve => {
        setTimeout(() => {
            resolve('resolved');
        }, 2000);
});
}
async function asyncCall() {
    let result = await resolveAfter2Seconds();
    console.log(result);
}
asyncCall()


// Promise.then
function logFetch(url) {
    return fetch(url)
        .then(response => {
            return response.text()
    })
    .then(text => {
        console.log(text);
    })
    .catch(err => {
        console.error(err);
    });
}
// Async-Await
async function logFetch(url) {
    try {
        const response = await fetch(url);
        console.log(await response.text());
    }
    catch (err) {
        console.log(err);
    }
}



function execute(x,sec) {
    return new Promise(resolve => {
        console.log('Start: ' + x);
        setTimeout(() => {
            console.log('End: ' + x);
            resolve(x);
        }, sec *1000); }); }
    
// Sequential Execution
async function serialFlow() {
    let result1 = await execute(1, 1);
    let result2 = await execute(2, 2);
    let result3 = await execute(3, 3);
    let finalResult = result1 + result2 + result3;
    console.log(finalResult);
}

// Concurrent Execution
async function parallelFlow() {
    let result1 = execute(1,1);
    let result2 = execute(2,2);
    let result3 = execute(3,3);
    let finalResult = await result1 +
                      await result2 +
                      await result3;
    console.log(finalResult);
}
    