function solve(number) {
    number = number.toString();
    let sum = 0;
    for (let digit of number) {
        sum += parseInt(digit);
    }
    console.log(sum);
}