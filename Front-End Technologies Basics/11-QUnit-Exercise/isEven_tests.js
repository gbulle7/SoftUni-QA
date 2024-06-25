const { isEven } = require('./test_functions.js')

QUnit.module("isEven function tests", () => {
    QUnit.test("Even numbers", function(assert) {
        assert.ok(isEven(2), "even number failed");
        assert.ok(isEven(0), "zero number failed");
    });

    QUnit.test("Odd numbers", function(assert) {
        assert.notOk(isEven(3), "odd number passed");
    });

    // negative number tests...
})