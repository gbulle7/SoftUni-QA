describe("Sum of numbers", () => {
    it("sum single number", () => {
        assert.equal(sum([1]), 1)
    });
    it("sum two same number", () => {
        assert.equal(sum([1, 1]), 2)
    });
    it("sum multiple numbers", () => {
        assert.equal(sum([1, 2, 3]), 6)
    });
    it("sum numbers as strings", () => {
        assert.equal(sum(['3', '5']), 8)
    });
});