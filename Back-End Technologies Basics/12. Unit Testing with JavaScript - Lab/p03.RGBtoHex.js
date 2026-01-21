describe("check if color is correct", () => {
    it("should return undefined if color negative", () => {
        assert.equal(rgbToHexColor(-1, 10, 10), undefined);
    });
    it("should return undefined if color negative", () => {
        assert.equal(rgbToHexColor(10, -1, 10), undefined);
    });
    it("should return undefined if color negative", () => {
        assert.equal(rgbToHexColor(10, 10, -1), undefined);
    });
    it("should return undefined if color above range", () => {
        assert.equal(rgbToHexColor(256, 0, 0), undefined);
    });
    it("should return undefined if color above range", () => {
        assert.equal(rgbToHexColor(0, 256, 0), undefined);
    });
    it("should return undefined if color above range", () => {
        assert.equal(rgbToHexColor(0, 0, 256), undefined);
    });
    it("should return undefined if color wrong type", () => {
        assert.equal(rgbToHexColor(0, 'b', 255), undefined);
    });
    it("should return undefined if color wrong type", () => {
        assert.equal(rgbToHexColor('a', 255, 255), undefined);
    });
    it("should return true if color correct", () => {
        assert.equal(rgbToHexColor(255, 0, '0'), '#FF0000');
    });
    it("should return true if color correct", () => {
        assert.equal(rgbToHexColor(50, 40, 30), '#32281E');
    });
    it("should return true if color correct", () => {
        assert.equal(rgbToHexColor(0, 0, 0), '#000000');
    });
    it("should return true if color correct", () => {
        assert.equal(rgbToHexColor(255, 255, 255), '#FFFFFF');
    });
});