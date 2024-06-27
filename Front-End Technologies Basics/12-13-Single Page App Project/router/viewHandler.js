import { render } from '../node_modules/lit-html/lit-html.js';
import page from '../node_modules/page/page.mjs';

import { requests } from '../api/requests.js';
import { templates } from '../templates/templates.js';

let mainElement = document.querySelector('#box #main-content');
let headerElement = document.querySelector('#box header');

async function homeView(ctx) {
    let games = await requests.games.getMostRecentGames();
    render(templates.getHomeTemplate(games), mainElement);
}

function navView(ctx, next) {
    render(templates.getNavTemplate(), headerElement);
    next();
}

async function loginView(ctx) {
    render(templates.getLoginTemplate(), mainElement);
}

async function registerView(ctx) {
    render(templates.getRegisterTemplate(), mainElement);
}

function logoutView(ctx) {
    requests.user.logout()
    .then(res => {
        if (res.status == 204) {
            sessionStorage.removeItem('game-user');
            page.redirect('/');
        }
    });
}

async function catalogView(ctx) {
    let games = await requests.games.getAll();
    render(templates.getCatalogTemplate(games), mainElement);
}

function createView(ctx) {
    render(templates.getCreateTemplate(), mainElement);
}

async function detailsView(ctx) {
    let game = await requests.games.getById(ctx.params.id);
    let comments = await requests.comments.getAll(ctx.params.id);
    render(templates.getDetailsTemplate(game, comments), mainElement);
}

async function editView(ctx) {
    let game = await requests.games.getById(ctx.params.id);
    render(templates.getEditTemplate(game), mainElement);
}

async function deleteView(ctx) {
    requests.games.deleteById(ctx.params.id)
    .then(res => {
        if (res.ok){
            page.redirect('/');
        }
    });
}

export const viewHandler = {
    homeView,
    navView,
    loginView,
    registerView,
    logoutView,
    catalogView,
    createView,
    detailsView,
    editView,
    deleteView
}