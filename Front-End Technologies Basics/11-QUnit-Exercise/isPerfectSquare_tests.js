const { isPerfectSquare } = require("./test_functions.js");

QUnit.module("isPerfectSquare function tests", () => {
    QUnit.test("1 as input", function(assert){
        assert.ok(isPerfectSquare(1), "1 as input");
    });

    QUnit.test("4 as input", function(assert){
        assert.ok(isPerfectSquare(4), "4 as input");
    });

    QUnit.test("9 as input", function(assert){
        assert.ok(isPerfectSquare(9), "9 as input");
    });

    QUnit.test("16 as input", function(assert){
        assert.ok(isPerfectSquare(16), "16 as input");
    });

    QUnit.test("2 as input", function(assert){
        assert.notOk(isPerfectSquare(2), "2 as input");
    });

    QUnit.test("15 as input", function(assert){
        assert.notOk(isPerfectSquare(15), "15 as input");
    });
})