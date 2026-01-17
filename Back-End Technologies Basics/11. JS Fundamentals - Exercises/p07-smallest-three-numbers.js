function printSmallest(a, b, c) {
    if (a < b && a < c) {
        console.log(a);
    }
    else if (b < a && b < c) {
        console.log(b);
    }
    else { console.log(c) };
}

printSmallest(2, 5, 3);
printSmallest(600, 342, 123);
printSmallest(25, 21, 4);
printSmallest(2, 2, 2);