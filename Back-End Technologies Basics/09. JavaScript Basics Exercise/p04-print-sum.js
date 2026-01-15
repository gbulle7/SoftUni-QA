function solve(arr) {
    start = parseInt(arr[0]);
    end = parseInt(arr[1]);
    let resultString = '';
    let resultSum = 0;
    for (let i = start; i <= end; i++) {
        resultSum += i;
        resultString += i + ' ';
    }
    console.log(resultString.trim());
    console.log("Sum: " + resultSum);
}