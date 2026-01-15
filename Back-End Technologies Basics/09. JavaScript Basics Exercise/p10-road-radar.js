function radar(arr) {
    speed = parseInt(arr[0]);
    area = arr[1]
    
    let limits = {
        "motorway": 130,
        "interstate": 90,
        "city": 50,
        "residential": 20
    };

    let limit = limits[area];
    if (speed <= limit) {
        console.log(`Driving ${speed} km/h in a ${limit} zone`);
    }
    else {
        let status;
        let difference = speed - limit;
        if (difference <= 20) {
            status = "speeding";
        }
        else if (difference <= 40) {
            status = "excessive speeding";
        }
        else {
            status = "reckless driving";
        }
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
    }
}