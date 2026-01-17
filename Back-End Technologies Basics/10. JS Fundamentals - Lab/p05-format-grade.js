function solve(grade) {
    grade = Number(grade).toFixed(2);
    let gradeName = "Excellent"
    let grades = {
        "Fail": 2.99,
        "Poor": 3.49,
        "Good": 4.49,
        "Very good": 5.49,
    }
    for (let [k, v] of Object.entries(grades)) {
        if (grade <= v) {
            gradeName = k;
            break;
        }
    }
    if (gradeName == "Fail") { grade = 2 }
    console.log(`${gradeName} (${grade})`);
}