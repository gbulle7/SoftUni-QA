import { expect } from 'chai'
import { artGallery } from '../05-ArtGallery.js';

describe("ArtGallery Tests", function() {
let gallery; 
    
    beforeEach(function() {
        gallery = artGallery;
    });
    
    describe("addArtwork() tests", function() {
        it("invalid title value should return Invalid Information", function() {
            expect(() => gallery.addArtwork(1, "30 x 40", "Van Gogh")).to.throw("Invalid Information!");
        });
        
        it("invalid dimension value should return Invalid Information", function() {
            expect(() => gallery.addArtwork("Artwork1", 3040, "Van Gogh")).to.throw("Invalid Dimensions!");
        });

        it("invalid dimension value should return Invalid Information", function() {
            expect(() => gallery.addArtwork("Artwork1", "30 z 40", "Van Gogh")).to.throw("Invalid Dimensions!");
        });
        
        it("invalid artist value should return Invalid Information", function() {
            expect(() => gallery.addArtwork("Artwork1", "30 x 40", 123)).to.throw("Invalid Information!");
        });
        
        // it("empty artist should return Invalid Information", function() {
        //     expect(() => gallery.addArtwork("Artwork1", "30 x 40")).to.throw("Invalid Information!");
        // });
        
        // it("empty title should return Invalid Information", function() {
        //     expect(() => gallery.addArtwork("", "30 x 40", "Van Gogh")).to.throw("Invalid Information!");
        // });
        
        // it("wrong artist should return error", function() {
        //     expect(() => gallery.addArtwork("Artwork1", "30 x 40", "Random Artist")).to.throw("This artist is not allowed in the gallery!");
        // });
     });
});