function employeesInfo(arr) {
    let employees = new Object();
    for (let employee of arr) {
        let personalNumber = employee.length;
        employees.employee = personalNumber;
        console.log(`Name: ${employee} -- Personal Number: ${personalNumber}`);
    }
}

employeesInfo([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]);