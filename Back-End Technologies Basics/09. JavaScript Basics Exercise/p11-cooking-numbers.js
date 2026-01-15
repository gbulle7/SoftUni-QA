function radar(arr) {
    let [num, ...commands] = arr;
    num = parseInt(num);
    
    let operations = {
        "chop": x => x / 2,
        "dice": x => Math.sqrt(x),
        "spice": x => x + 1,
        "bake": x => x * 3,
        "fillet": x => x * 0.8
    };
    for (let cmd of commands) {
        console.log(cmd);
        num = operations[cmd](num);
        console.log(num);
    }
}