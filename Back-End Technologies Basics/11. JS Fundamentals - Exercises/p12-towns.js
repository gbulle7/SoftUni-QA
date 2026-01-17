function townLocation(arr) {
    let towns = [];

    for (let town of arr) {
        let [townName, lat, long] = town.split(" | ");
        towns.push({
            town: townName,
            latitude: Number(lat).toFixed(2),
            longitude: Number(long).toFixed(2)
        });
    }

    towns.forEach((town) => console.log(town));
}

townLocation(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']
    )