function solve(n, array) {
    array = array.slice(0, n).reverse().join(" ");
    console.log(array);
}

solve(3, [10, 20, 30, 40, 50]);
solve(4, [-1, 20, 99, 5]);