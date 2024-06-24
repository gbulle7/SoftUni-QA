import { add, subtract } from "../functions.js"

QUnit.module("Math operations", {
    beforeEach: function () {
        //exec code before each test
    },
    afterEach: function () {
        //exec code after each test
    }
}, function() {
    QUnit.test("add test", function(assert) {
        assert.equal(add(1, 2), 3, "1+2 should be equal to 3");
    });
    QUnit.test("subtraction test", function(assert){
        assert.equal(subtract(2, 2), 0, "2-2 should be equal to 0");
    })
});