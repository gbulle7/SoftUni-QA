describe("arrayAnalyzer tests", () => {
    it("should return correct object values when given array of numbers", () => {
        expect(analyzeArray([1, 2, 3])).to.deep.equal({
            min: 1,
            max: 3,
            length: 3
        });
    });
    
    it("should return undefined when given an empty array", () => {
        expect(analyzeArray([])).to.be.undefined;
    });
    
    it("should return undefined when given non-array input - integer", () => {
        expect(analyzeArray(1)).to.be.undefined;
    });
    
    it("should return undefined when given non-array input - string", () => {
        expect(analyzeArray("1, 2, 3")).to.be.undefined;
    });
    
    it("should return correct object values when given a single element array", () => {
        expect(analyzeArray([4])).to.deep.equal({
            min: 4,
            max: 4,
            length: 1
        });
    });
    
    it("should return correct object values when given equal elements array", () => {
        expect(analyzeArray([5, 5, 5])).to.deep.equal({
            min: 5,
            max: 5,
            length: 3
        });
    });
});

