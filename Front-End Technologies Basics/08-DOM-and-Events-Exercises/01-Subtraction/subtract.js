//  With a button
function subtract() {
    let firstInput = document.getElementById('firstNumber').value;
    let secondInput = document.getElementById('secondNumber').value;
    let resultDiv = document.getElementById("result");

    let result = Number(firstInput) - Number(secondInput);
    resultDiv.textContent = result;
} 


// Automatically recalculate - Without a button
// document.getElementById('firstNumber').addEventListener('input', subtract);
// document.getElementById('secondNumber').addEventListener('input', subtract);



// function subtract() {
//     const num1 = Number(document.getElementById('firstNumber').value);
//     const num2 = Number(document.getElementById('secondNumber').value);

//     let sum = num1 - num2;

//     const result = document.getElementById('result').textContent = sum;
// }