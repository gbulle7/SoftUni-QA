import { add, subtract } from "../functions.js"


QUnit.module("Assertions tests");

QUnit.test('ok() assertion method', function(assert) {
    assert.ok(1, "1 is true");
    assert.ok('Hello', 'Hello string is true');
});

QUnit.test('notOk() assertion method', function(assert) {
    assert.notOk(0, "1 is false");
    assert.notOk('', 'empty string is false');
});

QUnit.test("throws() assertion method", function(assert) {
    function throwError() {
        throw new Error("Error!");
    }
    assert.throws(function(){throwError();}, /Error!/, "function should throw an Error!");
})

QUnit.test("equal() assertion method", function(assert) {
    assert.equal(1, '1', "1 == '1' to be true");
})

QUnit.test("strictEqual() assertion method", function(assert) {
    assert.strictEqual(1, 1, "1 === 1 to be true");
})

QUnit.test("deepEqual() assertion method", function(assert) {
    let obj1 = {a: 1};
    let obj2 = {a: 1};
    assert.deepEqual(obj1, obj2, "obj1 should be equal to obj2");
})

// notEqual(), notStrictEqual(), notDeepEqual()

QUnit.test('asynchronous test example', function(assert) {
    var done = assert.async();
    setTimeout(function() {
    assert.ok(true, 'asynchronous test passed');
    done();
    }, 2000);
});
   