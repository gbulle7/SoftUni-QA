const baseUrl = 'http://localhost:3030/'

let user = {
    email: "",
    password: "123456"
}

let token = "";
let userId = "";

let game = {
    title: '',
    category: '',
    maxLevel: '91',
    imageUrl: '/images/ZombieLang.png',
    summary: ''
}

let lastCreatedGameId = '';
let gameIdForComments = '';

QUnit.config.reorder = false;

QUnit.module("user functionalities", () => {
    QUnit.test("registration", async (assert) => {
        //arrange
        let path = 'users/register';
        let random = Math.floor(Math.random() * 10000);
        let email = `abv${random}@abv.bg`;
        user.email = email;

        //act
        let response = await fetch(baseUrl + path, {
            method: "POST",
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, "User registered successfully!");

        assert.ok(json.hasOwnProperty('email'), 'Email exists.');
        assert.equal(json['email'], user.email, 'Correct expected email');
        assert.strictEqual(typeof json.email, 'string', 'Email has correct property type');

        assert.ok(json.hasOwnProperty('password'), 'Password exists.');
        assert.equal(json['password'], user.password, 'Correct expected password');
        assert.strictEqual(typeof json.password, 'string', 'Password has correct property type');

        assert.ok(json.hasOwnProperty('accessToken'), 'AccessToken exists');
        assert.strictEqual(typeof json.accessToken, 'string', 'AccessToken has correct property type');

        assert.ok(json.hasOwnProperty('_id'), 'ID exists');
        assert.strictEqual(typeof json._id, 'string', 'ID has correct property type');

        token = json['accessToken'];
        userId = json['_id'];
        sessionStorage.setItem('game-user', JSON.stringify(user));
    });

    QUnit.test("login", async (assert) => {
        //arange
        let path = 'users/login';

        //act
        let response = await fetch(baseUrl + path, {
            method: 'POST',
            headers: {
                "content-type" : "application/json"
            },
            body: JSON.stringify(user)
        });
        let json = await response.json();

        //assert
        assert.ok(response.ok, "User logged in correctly");
        
        assert.ok(json.hasOwnProperty('email'), 'Email exists.');
        assert.equal(json['email'], user.email, 'Correct expected email');
        assert.strictEqual(typeof json.email, 'string', 'Email has correct property type');

        assert.ok(json.hasOwnProperty('password'), 'Password exists.');
        assert.equal(json['password'], user.password, 'Correct expected password');
        assert.strictEqual(typeof json.password, 'string', 'Password has correct property type');

        assert.ok(json.hasOwnProperty('accessToken'), 'AccessToken exists');
        assert.strictEqual(typeof json.accessToken, 'string', 'AccessToken has correct property type');

        assert.ok(json.hasOwnProperty('_id'), 'ID exists');
        assert.strictEqual(typeof json._id, 'string', 'ID has correct property type');

        token = json['accessToken'];
        userId = json['_id'];
        sessionStorage.setItem('game-user', JSON.stringify(user));
    });
});

QUnit.module("games functionalities", () => {
    QUnit.test("get all games", async (assert) => {
        //arrange
        let path = 'data/games';
        let queryParams = '?sortBy=_createdOn%20desc';

        //act
        let response = await fetch(baseUrl + path + queryParams);
        let json = await response.json();

        //assert
        assert.ok(response.ok, 'Successful response');
        assert.ok(Array.isArray(json), "Response is array");
        
        json.forEach(game => {
            assert.ok(game.hasOwnProperty("category", "Property category exists"));
            assert.strictEqual(typeof game.category, 'string', "Property category has correct type");
            
            assert.ok(game.hasOwnProperty("imageUrl", "Property imageUrl exists"));
            assert.strictEqual(typeof game.imageUrl, 'string', "imageUrl category has correct type");

            assert.ok(game.hasOwnProperty("title", "Property title exists"));
            assert.strictEqual(typeof game.title, 'string', "Property title has correct type");

            assert.ok(game.hasOwnProperty("maxLevel", "Property maxLevel exists"));
            assert.strictEqual(typeof game.maxLevel, 'string', "Property maxLevel has correct type");

            assert.ok(game.hasOwnProperty("summary", "Property summary exists"));
            assert.strictEqual(typeof game.summary, 'string', "Property summary has correct type");

            assert.ok(game.hasOwnProperty("_createdOn", "Property _createdOn exists"));
            assert.strictEqual(typeof game._createdOn, 'number', "Property _createdOn has correct type");

            assert.ok(game.hasOwnProperty("_id", "Property _id exists"));
            assert.strictEqual(typeof game._id, 'string', "Property _id has correct type");
            
            assert.ok(game.hasOwnProperty("_ownerId", "Property _ownerId exists"));
            assert.strictEqual(typeof game._ownerId, 'string', "Property _ownerId has correct type");
        });
    });

    QUnit.test('create game', async (assert) => {
        //arrange
        let path = 'data/games';
        let random = Math.floor(Math.random() * 10000);

        game.title = `Random game title ${random}`;
        game.category = `Random game category ${random}`;
        game.summary = `Random game summary ${random}`;

        //act
        let response = await fetch(baseUrl + path, {
            method: 'POST',
            headers: {
                'content-type': 'application/json',
                'X-Authorization': token
            },
            body: JSON.stringify(game)
        });
        let json = await response.json();
        lastCreatedGameId = json._id;

        //assert
        assert.ok(response.ok, 'Successful response');

        assert.ok(json.hasOwnProperty('category'), "Property category exists");
        assert.strictEqual(typeof json.category, 'string', 'Property category has correct type');
        assert.strictEqual(json.category, game.category, 'Property category has expected value');

        assert.ok(json.hasOwnProperty('imageUrl'), "Property imageUrl exists");
        assert.strictEqual(typeof json.imageUrl, 'string', 'Property imageUrl has correct type');
        assert.strictEqual(json.imageUrl, game.imageUrl, 'Property imageUrl has expected value');

        assert.ok(json.hasOwnProperty('maxLevel'), "Property maxLevel exists");
        assert.strictEqual(typeof json.maxLevel, 'string', 'Property maxLevel has correct type');
        assert.strictEqual(json.maxLevel, game.maxLevel, 'Property maxLevel has expected value');

        assert.ok(json.hasOwnProperty('summary'), "Property summary exists");
        assert.strictEqual(typeof json.summary, 'string', 'Property summary has correct type');
        assert.strictEqual(json.summary, game.summary, 'Property summary has expected value');

        assert.ok(json.hasOwnProperty('title'), "Property title exists");
        assert.strictEqual(typeof json.title, 'string', 'Property title has correct type');
        assert.strictEqual(json.title, game.title, 'Property title has expected value');

        assert.ok(json.hasOwnProperty('_createdOn'), "Property _createdOn exists");
        assert.strictEqual(typeof json._createdOn, 'number', 'Property _createdOn has correct type');

        assert.ok(json.hasOwnProperty('_id'), "Property _id exists");
        assert.strictEqual(typeof json._id, 'string', 'Property _id has correct type');

        assert.ok(json.hasOwnProperty('_ownerId'), "Property _ownerId exists");
        assert.strictEqual(typeof json._ownerId, 'string', 'Property _ownerId has correct type');
    });

    QUnit.test('get by id functionality', async (assert) => {
        //arrange
        let path = 'data/games';
    
        //act
        let response = await fetch(baseUrl + path + `/${lastCreatedGameId}`);
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, 'Successful response');

        assert.ok(json.hasOwnProperty('category'), "Property category exists");
        assert.strictEqual(typeof json.category, 'string', 'Property category has correct type');
        assert.strictEqual(json.category, game.category, 'Property category has expected value');

        assert.ok(json.hasOwnProperty('imageUrl'), "Property imageUrl exists");
        assert.strictEqual(typeof json.imageUrl, 'string', 'Property imageUrl has correct type');
        assert.strictEqual(json.imageUrl, game.imageUrl, 'Property imageUrl has expected value');

        assert.ok(json.hasOwnProperty('maxLevel'), "Property maxLevel exists");
        assert.strictEqual(typeof json.maxLevel, 'string', 'Property maxLevel has correct type');
        assert.strictEqual(json.maxLevel, game.maxLevel, 'Property maxLevel has expected value');

        assert.ok(json.hasOwnProperty('summary'), "Property summary exists");
        assert.strictEqual(typeof json.summary, 'string', 'Property summary has correct type');
        assert.strictEqual(json.summary, game.summary, 'Property summary has expected value');

        assert.ok(json.hasOwnProperty('title'), "Property title exists");
        assert.strictEqual(typeof json.title, 'string', 'Property title has correct type');
        assert.strictEqual(json.title, game.title, 'Property title has expected value');

        assert.ok(json.hasOwnProperty('_createdOn'), "Property _createdOn exists");
        assert.strictEqual(typeof json._createdOn, 'number', 'Property _createdOn has correct type');

        assert.ok(json.hasOwnProperty('_id'), "Property _id exists");
        assert.strictEqual(typeof json._id, 'string', 'Property _id has correct type');

        assert.ok(json.hasOwnProperty('_ownerId'), "Property _ownerId exists");
        assert.strictEqual(typeof json._ownerId, 'string', 'Property _ownerId has correct type');
    });

    QUnit.test('edit game', async (assert) => {
        //arrange
        let path = 'data/games';
        let random = Math.floor(Math.random() * 10000);

        game.title = `Updated game title ${random}`;
        game.category = `Updated game category ${random}`;
        game.summary = `Updated game summary ${random}`;

        //act
        let response = await fetch(baseUrl + path + `/${lastCreatedGameId}`, {
            method: 'PUT',
            headers: {
                'content-type': 'application/json',
                'X-Authorization': token
            },
            body: JSON.stringify(game)
        });
        let json = await response.json();

        //asserts
        assert.ok(response.ok, 'Successful response');

        assert.ok(json.hasOwnProperty('category'), "Property category exists");
        assert.strictEqual(typeof json.category, 'string', 'Property category has correct type');
        assert.strictEqual(json.category, game.category, 'Property category has expected value');

        assert.ok(json.hasOwnProperty('imageUrl'), "Property imageUrl exists");
        assert.strictEqual(typeof json.imageUrl, 'string', 'Property imageUrl has correct type');
        assert.strictEqual(json.imageUrl, game.imageUrl, 'Property imageUrl has expected value');

        assert.ok(json.hasOwnProperty('maxLevel'), "Property maxLevel exists");
        assert.strictEqual(typeof json.maxLevel, 'string', 'Property maxLevel has correct type');
        assert.strictEqual(json.maxLevel, game.maxLevel, 'Property maxLevel has expected value');

        assert.ok(json.hasOwnProperty('summary'), "Property summary exists");
        assert.strictEqual(typeof json.summary, 'string', 'Property summary has correct type');
        assert.strictEqual(json.summary, game.summary, 'Property summary has expected value');

        assert.ok(json.hasOwnProperty('title'), "Property title exists");
        assert.strictEqual(typeof json.title, 'string', 'Property title has correct type');
        assert.strictEqual(json.title, game.title, 'Property title has expected value');

        assert.ok(json.hasOwnProperty('_createdOn'), "Property _createdOn exists");
        assert.strictEqual(typeof json._createdOn, 'number', 'Property _createdOn has correct type');

        assert.ok(json.hasOwnProperty('_id'), "Property _id exists");
        assert.strictEqual(typeof json._id, 'string', 'Property _id has correct type');

        assert.ok(json.hasOwnProperty('_ownerId'), "Property _ownerId exists");
        assert.strictEqual(typeof json._ownerId, 'string', 'Property _ownerId has correct type');

        assert.ok(json.hasOwnProperty('_updatedOn'), "Property _updatedOn exists");
        assert.strictEqual(typeof json._updatedOn, 'number', 'Property _updatedOn has correct type');
    });

    QUnit.test('delete game functionality', async (assert) => {
        //arrange
        let path = 'data/games';
    
        //act
        let response = await fetch(baseUrl + path + `/${lastCreatedGameId}`, {
            method: 'DELETE',
            headers: {
                'X-Authorization': token
            }
        });
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, 'Deleted sucessfully');
    });
});

QUnit.module("comments functionalities", () => {
    QUnit.test('newly created game - no comments (empty)', async (assert) => {
        //arrange
        let path = 'data/comments';

        //create new game
        gameIdForComments = (await fetch(baseUrl + path, {
            method: 'POST',
            headers: {
                'content-type': 'application/json',
                'X-Authorization': token
            },
            body: JSON.stringify(game)
        })
        .then(response => response.json()))._id;
        
        let queryParams = `?where=gameId%3D%22${gameIdForComments}%22`

        //act
        let response = await fetch(baseUrl + path + queryParams);
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, 'Successful response');
        assert.ok(Array.isArray(json), 'Response is array');
        assert.ok(json.length == 0, 'Array is empty');
        // assert.equal(json.length, 0, 'Array is empty');
    });

    QUnit.test('create a new comment', async (assert) => {
        //arrange
        let path = 'data/comments';
        let random = Math.floor(Math.random() * 10000);
        let comment = {
            gameId: gameIdForComments,
            comment: `comment content ${random}`
        };

        //act
        let response = await fetch(baseUrl + path, {
            method: 'POST',
            headers: {
                'content-type': 'application/json',
                'X-Authorization': token
            },
            body: JSON.stringify(comment)
        });
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, 'Successful response');

        assert.ok(json.hasOwnProperty('comment'), "Property comment exists");
        assert.strictEqual(typeof json.comment, 'string', 'Property comment has correct type');
        assert.strictEqual(json.comment, comment.comment, 'Property comment has expected value');

        assert.ok(json.hasOwnProperty('gameId'), "Property gameId exists");
        assert.strictEqual(typeof json.gameId, 'string', 'Property gameId has correct type');
        assert.strictEqual(json.gameId, comment.gameId, 'Property gameId has expected value');
       
        assert.ok(json.hasOwnProperty('_createdOn'), "Property _createdOn exists");
        assert.strictEqual(typeof json._createdOn, 'number', 'Property _createdOn has correct type');
        
        assert.ok(json.hasOwnProperty('_id'), "Property _id exists");
        assert.strictEqual(typeof json._id, 'string', 'Property _id has correct type');
    });

    QUnit.test('get comments by game ID', async (assert) => {
        //arrange
        let path = 'data/comments';
        let queryParams = `?where=gameId%3D%22${gameIdForComments}%22`
        
        //act
        let response = await fetch(baseUrl + path + queryParams);
        let json = await response.json();
        
        //assert
        assert.ok(response.ok, 'Successful response');
        assert.ok(Array.isArray(json), 'The response is array');

        json.forEach(comment => {
            assert.ok(comment.hasOwnProperty('comment'), "Property comment exists");
            assert.strictEqual(typeof comment.comment, 'string', 'Property comment has correct type');
    
            assert.ok(comment.hasOwnProperty('gameId'), "Property gameId exists");
            assert.strictEqual(typeof comment.gameId, 'string', 'Property gameId has correct type');
           
            assert.ok(comment.hasOwnProperty('_createdOn'), "Property _createdOn exists");
            assert.strictEqual(typeof comment._createdOn, 'number', 'Property _createdOn has correct type');
            
            assert.ok(comment.hasOwnProperty('_id'), "Property _id exists");
            assert.strictEqual(typeof comment._id, 'string', 'Property _id has correct type');
        });
    });
});

// Optimize - function generate_random_...(); function post_request(); function put_request();