function storeProvision(currentStock, orderedProducts) {
    let allProducts = {};
    for (i = 0; i < currentStock.length; i += 2) {
        allProducts[currentStock[i]] = parseInt(currentStock[i + 1]);
    }
    for (i = 0; i < orderedProducts.length; i += 2) {
        let product = orderedProducts[i];
        let quantity = parseInt(orderedProducts[i + 1]);
        if (!(product in allProducts)) {
            allProducts[product] = 0;
        }
        allProducts[product] += quantity;
    }

    for (let p in allProducts) {
        console.log(`${p} -> ${allProducts[p]}`)
    }
}

storeProvision([
    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    ],
    [
    'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]);