const { nthPrime } = require("./test_functions.js");

QUnit.module("nthPrime function tests", () => {
    QUnit.test("1st Prime", function(assert){
        assert.equal(nthPrime(1), 2, "1st Prime")
    });

    QUnit.test("5th Prime", function(assert){
        assert.equal(nthPrime(5), 11, "5th Prime")
    });

    QUnit.test("11th Prime", function(assert){
        assert.equal(nthPrime(11), 31, "11th Prime")
    });
})