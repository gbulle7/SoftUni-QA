function solve(arr) {
    let fruit = arr[0];
    let weightKg = arr[1] * 0.001;
    let priceKg = arr[2]
    let price = priceKg * weightKg;
    console.log(`I need $${price.toFixed(2)} to buy ${weightKg.toFixed(2)} kilograms ${fruit}.`);
}