const { fetchData } = require("./async_test_functions.js");

QUnit.module("fetchData function tests", () => {
    QUnit.test("fetch data from correct url", async function(assert) {
        const data = await fetchData("https://www.zippopotam.us/bg/8000");

        assert.ok(data.hasOwnProperty("post code"), "Checking for specific property");
        assert.equal(data['post code'], '8000', 'post code should be 8000');

        assert.ok(data.hasOwnProperty("country"), "Checking for specific property");
        assert.equal(data['country'], 'Bulgaria', 'country should be Bulgaria');

        assert.ok(data.hasOwnProperty("country abbreviation"), "Checking for specific property");
        assert.equal(data['country abbreviation'], 'BG', 'country abbreviation should be BG');

        assert.ok(Array.isArray(data.places), '"places" should be an array');
        assert.equal(data.places.length, 1, 'length of "places" array should be 1');

        const place = data.places[0];
        assert.ok(place.hasOwnProperty('place name'), 'Checking for specific property');
        assert.equal(place['place name'], 'Бургас / Burgas', 'place name should be Бургас / Burgas');

        assert.ok(place.hasOwnProperty('longitude'), 'Checking for specific property');
        assert.equal(place['longitude'], '27.4667', 'longitude should be 27.4667');

        assert.ok(place.hasOwnProperty('state'), 'Checking for specific property');
        assert.equal(place['state'], 'Бургас / Burgas', 'state should be Бургас / Burgas');

        assert.ok(place.hasOwnProperty('state abbreviation'), 'Checking for specific property');
        assert.equal(place['state abbreviation'], 'BGS', 'state abbreviation should be BGS');

        assert.ok(place.hasOwnProperty('latitude'), 'Checking for specific property');
        assert.equal(place['latitude'], '42.5', 'latitude should be 27.4667');
    })

    QUnit.test("With invalid postal code", async function(assert) {
            const data = await fetchData("https://www.zippopotam.us/bg/8000999");

            assert.notOk(data);
            assert.true(data === undefined);
        });

    QUnit.test("With non-existent url", async function(assert) {
        const data = await fetchData("https://wwwww.zippopotam.us/bg/8000");

        assert.equal(data, 'fetch failed');
    });
})