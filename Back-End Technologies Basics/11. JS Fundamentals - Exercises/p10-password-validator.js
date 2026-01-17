function checkPassword(password) {
    let valid = true;
    if (password.length < 6 || password.length > 10) {
        valid = false;
        console.log("Password must be between 6 and 10 characters");
    }
    if (!password.match(/^[A-Za-z0-9]+$/)) {
        valid = false;
        console.log("Password must consist only of letters and digits");
    }
    let counter = 0;
    for (let char of password) {
        if (!isNaN(parseInt(char))) {
            counter++;
            if (counter >= 2){break;}
        }
    }
    if (counter < 2) {
        valid = false;
        console.log("Password must have at least 2 digits")
    }

    if (valid) {
        console.log('Password is valid');
    }
}

checkPassword('logIn');
checkPassword('MyPass123');
checkPassword('Pa$s$s');

/*
function solve(password) {
    'use strict';

    const errors = [];

    if (password.length < 6 || password.length > 10) {
        errors.push('Password must be between 6 and 10 characters');
    }

    const regexOnlyLettersAndDigits = /^[A-Za-z0-9]+$/;

    if (!password.match(regexOnlyLettersAndDigits)) {
        errors.push('Password must consist only of letters and digits');
    }

    const countDigitsInString = (word) => {
        let counter = 0;

        for (const char of word) {
            if (!isNaN(parseInt(char))) {
                counter++;
            }
        }

        return counter;
    }

    const numberOfDigitsInString = countDigitsInString(password);

    if (numberOfDigitsInString < 2) {
        errors.push('Password must have at least 2 digits');
    }

    if (errors.length === 0) {
        console.log('Password is valid')
    }
    else {
        errors.forEach((error) => console.log(error));
    }
}
*/