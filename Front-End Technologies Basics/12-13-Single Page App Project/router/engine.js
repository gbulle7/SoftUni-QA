import page from '../node_modules/page/page.mjs';
import { viewHandler } from './viewHandler.js';

function start() {
    page(viewHandler.navView);
    page('/', viewHandler.homeView);
    page('/login', viewHandler.loginView);
    page('/logout', viewHandler.logoutView);
    page('/register', viewHandler.registerView);
    page('/catalog', viewHandler.catalogView);
    page('/create', viewHandler.createView);
    page('/details/:id', viewHandler.detailsView);
    page('/edit/:id', viewHandler.editView);
    page('/delete/:id', viewHandler.deleteView);
    page.start();
}

export const engine = {
    start
}