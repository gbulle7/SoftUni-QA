function solve(string, occ) {
    counter = 0;
    let stringArr = string.split(" ");
    for (let word of stringArr) {
        if (word === occ) {
            counter++;
        }
    }
    console.log(counter);
}