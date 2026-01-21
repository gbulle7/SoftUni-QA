describe("check if array is symmetric", () => {
    it("should return false if not array", () => {
        assert.isFalse(isSymmetric('string'));
    });
    it("should return false if not symmetric", () => {
        assert.isFalse(isSymmetric([1, 2, 3]));
    });
    it("should return true if symmetric number array", () => {
        assert.isTrue(isSymmetric([1, 2, 3, 2, 1]))
    });
    it("should return false if not symmetric mixed array", () => {
        assert.isFalse(isSymmetric(["1", "2", 3, 2, 1]))
    });
    it("should return true if symmetric mixed array", () => {
        assert.isFalse(isSymmetric(["1", "2", 3, "2", "1"]))
    });
    it("should return true if symmetric string array", () => {
        assert.isTrue(isSymmetric(["1", "2", "3", "2", "1"]))
    });
});