import { add } from "../functions.js"

QUnit.module("add", function() {
    QUnit.test("two numbers", assertAddFunction);

function assertAddFunction(assert) {
    QUnit.assert.equal(add(1, 2), 3);
}
});


// QUnit.module("add");
// QUnit.test("two numbers", function (assert) {
//     assert.equal(add(1, 2), 3);
// });

// QUnit.module("add2");
// QUnit.test("two numbers", function (assert) {
//     assert.equal(add(1, 2), 3);
// });


/*
QUnit.test("two numbers", function assertAddFunction(assert) {
    assert.equal(add(1, 2), 3);
}); 
*/