function solve(num) {
    let stringNum = num.toString();
    let firstDigit = stringNum[0];
    let isSame = true;
    let result = 0;
    for (let digit of num.toString()) {
        if (isSame && digit != firstDigit) {isSame = false;}
        result += parseInt(digit);
    }
    console.log(isSame);
    console.log(result);
}