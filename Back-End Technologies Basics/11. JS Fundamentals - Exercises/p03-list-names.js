function solve(arr) {
    arr.sort((a, b) => a.localeCompare(b));
    counter = 0;
    for (let name of arr) {
        console.log(`${++counter}.${name}`)
    }
}