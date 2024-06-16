async function chainedPromisesAsync() {
    let p1 = new Promise((resolve) => setTimeout(() => {
        resolve("1 second"); 
     }, 1000));
 
     let p2 = new Promise((resolve) => setTimeout(() => {
         resolve("2 seconds"); 
      }, 2000));
 
      let p3 = new Promise((resolve) => setTimeout(() => {
         resolve("3 seconds"); 
      }, 3000));
 
      let result1 = await p1;
      let result2 = await p2;
      let result3 = await p3;

      console.log(`${result1}, ${result2}, ${result3}`);
}



// CONCURRENTLY
// async function chainedPromisesAsync() {
//     const p1 = new Promise(resolve => setTimeout(() => resolve("First"), 1000));
//     const p2 = new Promise(resolve => setTimeout(() => resolve("Second"), 2000));
//     const p3 = new Promise(resolve => setTimeout(() => resolve("Third"), 3000));

//     const result1 = await p1;
//     const result2 = await p2;
//     const result3 = await p3;

//     console.log(result1, result2, result3);
// }

// SEQUENTIALLY
// async function chainedPromisesAsync() {
//     const p1 = await new Promise(resolve => setTimeout(() => resolve("First"), 1000));
//     const p2 = await new Promise(resolve => setTimeout(() => resolve("Second"), 2000));
//     const p3 = await new Promise(resolve => setTimeout(() => resolve("Third"), 3000));
//     console.log(p1, p2, p3);
// }