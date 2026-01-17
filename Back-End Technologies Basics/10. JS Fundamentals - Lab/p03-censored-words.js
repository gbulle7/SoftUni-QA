function solve(string, censor) {
    let newString = string;
    while (newString.includes(censor)) {
        newString = newString.replace(censor, '*'.repeat(censor.length));
    }
    console.log(newString);
}