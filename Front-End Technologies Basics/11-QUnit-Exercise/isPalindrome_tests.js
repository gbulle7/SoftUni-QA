const { isPalindrome } = require("./test_functions.js");

QUnit.module("isPalindrome function tests", () => {
    QUnit.test("single word palindrome", function(assert) {
        assert.ok(isPalindrome("racecar"), "single word palindrome");
    });

    QUnit.test("multi words palindrome", function(assert) {
        assert.ok(isPalindrome("A man, a plan, a canal, Panama!"), "multi words palindrome");
    });

    QUnit.test("single word non palindrome", function(assert) {
        assert.notOk(isPalindrome("Hello"), "single word non palindrome");
    });

    QUnit.test("empty string as input", function(assert) {
        assert.notOk(isPalindrome(""), "empty string as input");
    });
})