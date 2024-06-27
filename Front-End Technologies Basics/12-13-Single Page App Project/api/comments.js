import { url } from '../utils/urls.js';
import { userInfo } from '../utils/userInfo.js';

async function getAll(gameId){
    return await fetch(url.getBaseUrl() + `/data/comments?where=gameId%3D%22${gameId}%22`)
    .then(res => res.json())
    .then(c => c);
}

async function postNew(comment) {
    return await fetch(url.getBaseUrl() + '/data/comments', {
        method : 'POST',
        headers : {
            'content-type': 'application/json',
            'X-Authorization': userInfo.getToken()
        },
        body : JSON.stringify(comment)
    });
}

export const comments = {
    getAll,
    postNew
}