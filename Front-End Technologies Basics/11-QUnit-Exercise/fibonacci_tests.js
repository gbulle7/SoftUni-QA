const { fibonacci } = require("./test_functions");

QUnit.module("fibonacci function tests", () => {
    QUnit.test("Zero as input", function(assert) {
        assert.deepEqual(fibonacci(0), [], "Zero as input");
    });

    QUnit.test("1 as input", function(assert) {
        assert.deepEqual(fibonacci(1), [0], "1 as input");
    });

    QUnit.test("5 as input", function(assert) {
        assert.deepEqual(fibonacci(5), [0, 1, 1, 2, 3], "5 as input");
    });

    QUnit.test("10 as input", function(assert) {
        assert.deepEqual(fibonacci(10), [0, 1, 1, 2, 3, 5, 8, 13, 21, 34], "10 as input");
    });
})