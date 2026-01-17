function solve(order, quantity) {
    let products = {
        coffee: 1.50,
        water: 1.00,
        coke: 1.40,
        snacks: 2.00
    }
    let totalPrice = products[order] * quantity;
    console.log(totalPrice.toFixed(2));
}