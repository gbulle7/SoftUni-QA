function solve(num) {
    let oddSum = 0;
    let evenSum = 0;
    for (let digit of num.toString()) {
        digit = parseInt(digit);
        if (digit % 2 == 0) {
            evenSum += digit;
        }
        else {
            oddSum += digit;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

solve(1000435);