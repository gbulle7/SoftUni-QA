import page from '../node_modules/page/page.mjs';
import { requests } from '../api/requests.js';

async function onLoginSubmit(evt) {
    evt.preventDefault();

    let formData = new FormData(evt.currentTarget);

    let { email, password } = Object.fromEntries(formData);

    await requests.user.login(email, password)
    .then(res => {
        if (!res.ok) {
            throw new Error('Unable to login!');
        }
        return res.json();
    })
    .then(user => {
        sessionStorage.setItem('game-user', JSON.stringify(user));
        page.redirect('/');
    })
    .catch(err => {
        alert(err.message);
    })
}

async function onRegisterSubmit(evt) {
    evt.preventDefault();

    let formData = new FormData(evt.currentTarget);

    let { email, password } = Object.fromEntries(formData);
    let repass = formData.get('confirm-password');
    if (isValidRegister(email, password, repass)) {
        let userInfo = {
            email,
            password,
            repass
        };

        requests.user.register(userInfo)
            .then(res => {
                if (!res.ok) {
                throw new Error("Registration is not successful");
            }
            return res.json();
            })
            .then(data => {
                sessionStorage.setItem('game-user', JSON.stringify(data));
                page.redirect('/');
            })
            .catch(err => {
                alert(err.message);
        });
    } else {
        alert('No empty fields are allowed and confirm password should match!');
    }
}

async function onCreateSubmit(evt) {
    evt.preventDefault();
    
    let formData = new FormData(evt.currentTarget);
    let {title, category, maxLevel, imageUrl, summary} = Object.fromEntries(formData);

    if (isValidCreatingOrEditing(title, category, maxLevel, imageUrl, summary))
        {
            let item = {
                title,
                category,
                maxLevel,
                imageUrl,
                summary
            };
            requests.games.create(item)
            .then(res => {
                if(!res.ok){
                    throw new Error("Unable to create a game");
                }
                return res.json();
            })
            .then(()=>{
                page.redirect('/');
            })
            .catch(err => alert(err.message));
        }
        else {
            alert("All fields are required");
        }
}

function onCommentSubmit(evt) {
    evt.preventDefault();

    let formData = new FormData(evt.currentTarget);
    let comment = formData.get('comment');
    let gameId = evt.currentTarget.getAttribute('gameid');
    let form = evt.currentTarget;

    requests.comments.postNew({gameId, comment})
    .then(res => {
        if(!res.ok){
            throw new Error("Unable to create a comment");
        }
        return res.json();
    })
    .then(com => {
        form.reset();
        page.redirect(`/details/${gameId}`);
    })
    .catch(err => alert(err.message));
}

async function onEditSubmit(evt) {
    evt.preventDefault();
    
    let formData = new FormData(evt.currentTarget);
    let id = evt.currentTarget.getAttribute('gameid');

    let {title, category, maxLevel, imageUrl, summary} = Object.fromEntries(formData);

    if (isValidCreatingOrEditing(title, category, maxLevel, imageUrl, summary))
        {
            let item = {
                title,
                category,
                maxLevel,
                imageUrl,
                summary
            };
            requests.games.edit(item, id)
            .then(res => {
                if(!res.ok){
                    throw new Error("Unable to create a game");
                }
                return res.json();
            })
            .then(()=>{
                page.redirect(`/details/${id}`);
            })
            .catch(err => alert(err.message));
        }
        else {
            alert("All fields are required");
        }
}

export const event = {
    onLoginSubmit,
    onRegisterSubmit,
    onCreateSubmit,
    onCommentSubmit,
    onEditSubmit
}

function isValidRegister(email, password, repass) {
    if (email == '' || password == '' || repass == '' || password != repass) {
        return false;
    }
    return true;
}

function isValidCreatingOrEditing(title, category, maxLevel, imageUrl, summary) {
    if (title == '' || category == '' || maxLevel == '' || imageUrl == '' || summary == '') {
        return false;
    }
    return true;
}