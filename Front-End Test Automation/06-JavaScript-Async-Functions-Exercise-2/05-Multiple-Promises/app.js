// function multiplePromises() {
//       const p1 = new Promise(resolve => setTimeout(() => resolve("Promise 1 is resolved"), 1000));
//       const p2 = new Promise(resolve => setTimeout(() => resolve("Promise 2 is resolved"), 2000));
//       const p3 = new Promise((_, reject) => setTimeout(() => reject("Promise 3 is rejected"), 3000));

//       Promise.allSettled([p1, p2, p3]).then(result => {
//             result.forEach(result => console.log(result.status, result.value || result.reason));
//       });
// }


async function multiplePromises() {
      const p1 = new Promise(resolve => setTimeout(() => resolve("Promise 1 is resolved"), 1000));
      const p2 = new Promise(resolve => setTimeout(() => resolve("Promise 2 is resolved"), 2000));
      const p3 = new Promise((_, reject) => setTimeout(() => reject("Promise 3 is rejected"), 3000));

      const result = await Promise.allSettled([p1, p2, p3]);
      result.forEach(result => console.log(result.status, result.value || result.reason));
}