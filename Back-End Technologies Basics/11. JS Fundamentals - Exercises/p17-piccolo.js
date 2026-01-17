function showParking(arr) {
    let parking = [];
    for (let tokens of arr) {
        let [direction, carNumber] = tokens.split(", ");
        if (direction == "IN") {
            parking.push(carNumber);
        }
        else {
            parking.pop(carNumber);
        }
    }
}

showParking(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']);