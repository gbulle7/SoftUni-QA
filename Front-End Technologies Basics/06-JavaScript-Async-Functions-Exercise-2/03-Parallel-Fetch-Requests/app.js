// async function fetchParallel() {
//   const [res1, ...rest] = await Promise.all([
//     fetch('https://swapi.dev/api/people/1').then(res => res.json()),
//     fetch('https://swapi.dev/api/people/2').then(res => res.json()),
//     fetch('https://swapi.dev/api/people/3').then(res => res.json())
//   ]);
//   console.log(res1, ...rest);   // console.log(res1, rest) will output res1 and on next line rest in array
// }

// async function fetchParallel() {
//   const [res1, res2] = await Promise.all([
//     fetch('https://swapi.dev/api/people/1').then(res => res.json()),
//     fetch('https://swapi.dev/api/people/2').then(res => res.json())
//   ]);
//   console.log(res1, res2);
// }

// async function fetchParallel() {
//   const array = await Promise.all([
//     fetch('https://swapi.dev/api/people/1').then(res => res.json()),
//     fetch('https://swapi.dev/api/people/2').then(res => res.json())
//   ]);
//   console.log(array);  // console.log(array[0], array[1]);
// }

// async function fetchParallel() {
//   const response1 = await fetch('https://swapi.dev/api/people/1');
//   const response2 = await fetch('https://swapi.dev/api/people/2');
//   const data1 = await response1.json();
//   const data2 = await response2.json();
//   const result = await Promise.all([data1, data2]);
//   console.log(result);
// }

async function fetchParallel() {
  const [res1, res2] = await Promise.all([
    fetch('https://swapi.dev/api/people/1'),
    fetch('https://swapi.dev/api/people/2')
  ]);
  const data1 = await res1.json();
  const data2 = await res2.json();
  console.log(data1, data2);
}