import { html } from "../node_modules/lit-html/lit-html.js";

export function getCatalogTemplate(games) {
    return html`<section id="catalog-page">
            <h1>All Games</h1>
            <!-- Display div: with information about every game (if any) -->
            ${games && games.length > 0
                ? games.map(g => html`
                    <div class="allGames">
                    <div class="allGames-info">
                    <img src=${g.imageUrl.substring(0, 1) == '/' ? `..${g.imageUrl}` : g.imageUrl}>
                    <h6>${g.category}</h6>
                    <h2>${g.title}</h2>
                    <a href="/details/${g._id}" class="details-button">Details</a>
                    </div>
                    </div>`)
                : html`<!-- Display paragraph: If there are no games  -->
                <h3 class="no-articles">No articles yet</h3>`
            } 
        </section>`;
}