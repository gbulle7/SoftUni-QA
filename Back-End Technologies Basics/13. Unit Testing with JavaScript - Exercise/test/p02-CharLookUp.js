describe("Char Lookup", () => {
    it("should return undefined when 1st parameter is not a string", () => {
        expect(lookupChar(123, 1)).to.be.undefined;
    });
    
    it("should return undefined when index is not an integer - string", () => {
        expect(lookupChar("123", "1")).to.be.undefined;
    });
    
    it("should return undefined when index is not an integer - float", () => {
        expect(lookupChar("123", 1.2)).to.be.undefined;
    });
    
    it("should return undefined when index is not in range, lower boundary", () => {
        expect(lookupChar("123", -1)).to.equal("Incorrect index");
    });
    
    it("should return undefined when index is not in range, upper boundary", () => {
        expect(lookupChar("123", 3)).to.equal("Incorrect index");
    });
    
    it("should return correct char when given correct values", () => {
        expect(lookupChar("123", 1)).to.equal("2");
    });
});