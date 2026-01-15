function calculatePrice(arr) {
    let numberPeople = parseInt(arr[0]);
    let groupType = arr[1];
    let day = arr[2];
    let price;
    let groupsPrices = {"Students": [8.45, 9.80, 10.46], "Business": [10.90, 15.60, 16], "Regular": [15, 20, 22.50]};
    let days = {"Friday": 0, "Saturday": 1, "Sunday": 2}
    let currDayIndex = days[day];
    for (const [key, value] of Object.entries(groupsPrices)) {
        if (groupType == key) {
            price = value[currDayIndex];
            break;
        }
    }
    let discount = 0;
    if (groupType == "Students" && numberPeople >= 30) {
        discount = 0.15;
    }
    else if (groupType == "Business" && numberPeople >= 100) {
        numberPeople -= 10;
    }
    else if (groupType == "Regular" && numberPeople >= 10 && numberPeople <= 20) {
        discount = 0.05;
    }
    let totalPrice = (price - price * discount) * numberPeople;
    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}