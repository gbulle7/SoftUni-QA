function solve(a, b, c) {
    const sum = (a, b) => a + b;
    const subtract = (s, c) => s - c;
    const result = subtract(sum(a, b), c);
    console.log(result);
}

solve(23, 6, 19);