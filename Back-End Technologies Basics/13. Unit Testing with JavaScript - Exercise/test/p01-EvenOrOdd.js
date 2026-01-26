describe("EvenOdd tests", () => {
     it("should return undefined if parameter is not a string", () => {
         expect(isOddOrEven(123)).to.be.undefined;
     });
     
     it("should return undefined when no parameter is passed", () => {
         expect(isOddOrEven()).to.be.undefined;
     });
     
     it("should return even if string length is even", () => {
         expect(isOddOrEven("1234")).to.equal("even");
     });
     
     it("should return odd if string length is odd", () => {
         expect(isOddOrEven("abc")).to.equal("odd");
     });
     
     it("multiple positive tests", () => {
         expect(isOddOrEven("check this string")).to.equal("odd");
         expect(isOddOrEven("    ")).to.equal("even");
         expect(isOddOrEven("a")).to.equal("odd");
     });
});