import { url } from '../utils/urls.js';
import { userInfo } from '../utils/userInfo.js';

async function getMostRecentGames() {
    return await fetch(url.getGamesUrl() + '?sortBy=_createdOn%20desc&distinct=category')
    .then(res => res.json())
    .then(items => items);
}

async function getAll() {
    return await fetch(url.getGamesUrl() + '?sortBy=_createdOn%20desc')
    .then(res => res.json())
    .then(items => items);
}

function create(item) {
    return fetch(url.getGamesUrl(), {
        method : "POST",
        headers : {
            'content-type' : 'application/json',
            'X-Authorization' : userInfo.getToken()
        },
        body : JSON.stringify(item)
    });
}

async function getById(id) {
    return await fetch(url.getGamesUrl() + `/${id}`)
    .then(res => res.json())
    .then(item => item);
}

function edit(item, id) {
    return fetch(url.getGamesUrl() + `/${id}`, {
        method : "PUT",
        headers : {
            'content-type' : 'application/json',
            'X-Authorization' : userInfo.getToken()
        },
        body : JSON.stringify(item)
    });
}

async function deleteById(id) {
    return fetch(url.getGamesUrl() + `/${id}`, {
        method: "DELETE",
        headers : {
            'X-Authorization' : userInfo.getToken()
        }
    });
}

export const games = {
    getMostRecentGames,
    getAll,
    create,
    getById,
    edit,
    deleteById
}