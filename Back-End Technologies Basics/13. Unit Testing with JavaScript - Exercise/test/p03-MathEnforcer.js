describe("mathEnforcer tests", () => {
    describe("addFive function tests", () => {
        it("should return correct value when given integer", () => {
        expect(mathEnforcer.addFive(10)).to.equal(15);
        });
        
        it("should return correct value when given float", () => {
        expect(mathEnforcer.addFive(11.11)).to.be.closeTo(16.11, 0.01);
        });
        
        it("should return correct value when given negative number", () => {
        expect(mathEnforcer.addFive(-12)).to.equal(-7);
        });
        
        it("should return undefined when parameter is not a number", () => {
        expect(mathEnforcer.addFive("10")).to.be.undefined;
        });
    });
    
    describe("subtractTen function tests", () => {
        it("should return correct value when given integer", () => {
        expect(mathEnforcer.subtractTen(8)).to.equal(-2);
        });
        
        it("should return correct value when given float", () => {
        expect(mathEnforcer.subtractTen(9.11)).to.be.closeTo(-0.89, 0.01);
        });
        
        it("should return correct value when given negative number", () => {
        expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
        });
        
        it("should return undefined when parameter is not a number", () => {
        expect(mathEnforcer.subtractTen("10")).to.be.undefined;
        });
    });
    
    describe("sum function tests", () => {
        it("should return correct value when given integers", () => {
        expect(mathEnforcer.sum(2, 3)).to.equal(5);
        });
        
        it("should return correct value when given floats", () => {
        expect(mathEnforcer.sum(2.22, 3.33)).to.be.closeTo(5.55, 0.01);
        });
        
        it("should return correct value when given negative integers", () => {
        expect(mathEnforcer.sum(-2, -3)).to.equal(-5);
        });
        
        it("should return undefined when 1st parameter is not a number", () => {
        expect(mathEnforcer.sum("10", 2)).to.be.undefined;
        });
        
        it("should return undefined when 2nd parameter is not a number", () => {
        expect(mathEnforcer.sum(10, "2")).to.be.undefined;
        });
        
        it("should return undefined when both parameters are not numbers", () => {
        expect(mathEnforcer.sum("10", "2")).to.be.undefined;
        });
    });
});

