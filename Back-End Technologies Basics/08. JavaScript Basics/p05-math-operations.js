function solve(a, b, op) {
    let result;
    switch (op) {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "*":
            result = a * b;
            break;
        case "/":
            result = a / b;
            break;
        case "%":
            result = a % b;
            break;
        case "**":
            result = a ** b;
            break;
    }
    console.log(result);
}

solve(5, 6, '+');
solve(3, 5.5, '*');
solve(2, 3, '/');
solve(3, 4, '**');
solve(3, 5, '%');
solve(4, 2, '-');