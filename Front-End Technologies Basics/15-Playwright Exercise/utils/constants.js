const BASE_URL = 'http://localhost:3000';

const TEST_URL = {
    TEST_HOME_URL: BASE_URL + '/',
    TEST_LOGIN_URL: BASE_URL + '/login',
    TEST_REGISTER_URL: BASE_URL + '/register',
    TEST_CATALOG_URL: BASE_URL + '/catalog'
}

const TEST_USER = {
    EMAIL: 'peter@abv.bg',
    PASSWORD: '123456'
}

const ALERT = {
    ALERT_MESSAGE: 'All fields are required!'
}

const TEST_BOOK = {
    TITLE: 'Test Book Title',
    DESCRIPTION: 'Test Book Description',
    IMAGE: '/images/book.png',
    TEST_BOOK_OPTIONS: {
        FICTION: 'Fiction',
        ROMANCE: 'Romance',
        MISTERY: 'Mistery',
        CLASSIC: 'Clasic',
        OTHER: 'Other'
    }
}

export {
    BASE_URL,
    TEST_URL,
    TEST_USER,
    ALERT,
    TEST_BOOK
}