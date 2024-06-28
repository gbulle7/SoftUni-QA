import { test, expect } from '@playwright/test';
import { ALL_BOOKS_LIST, CREATE_FORM, DETAILS_BUTTONS, DETAILS_DESCRIPTION, LOGGED_NAVBAR, LOGIN_FORM, NAVBAR } from '../utils/locators.js';
import { ALERT, BASE_URL, TEST_BOOK, TEST_URL, TEST_USER } from '../utils/constants.js';

// Navigation, method 1
// test('Verify "All books" link is visible', async ({ page }) => {
//     await page.goto('http://localhost:3000');

//     await page.waitForSelector('nav.navbar');
//     const allBooksLink = await page.$('a[href="/catalog"]');
//     const isLinkVisible = await allBooksLink.isVisible();
//     expect(isLinkVisible).toBe(true);
// });

// Navigation, method 2
test('Verify "All books" link is visible', async ({ page }) => {
    await page.goto(BASE_URL);

    await expect(page.locator(NAVBAR.NAV_NAVBAR)).toBeVisible();
    await expect(page.locator(NAVBAR.ALL_BOOKS_LINK)).toBeVisible();
});

test('Verify "Login" button is visible', async ({ page }) => {
    await page.goto(BASE_URL);

    await expect(page.locator(NAVBAR.NAV_NAVBAR)).toBeVisible();
    await expect(page.locator(NAVBAR.LOGIN_BUTTON)).toBeVisible();
});

test('Verify "Register" button is visible', async ({ page }) => {
    await page.goto(BASE_URL);

    await expect(page.locator(NAVBAR.NAV_NAVBAR)).toBeVisible();

    await expect(page.locator(NAVBAR.REGISTER_BUTTON)).toBeVisible();
});

test('Verify "All books" link is visible after user login', async ({ page }) => {
    await page.goto(BASE_URL);

    await expect(page.locator(NAVBAR.LOGIN_BUTTON)).toBeVisible();
    await page.locator(NAVBAR.LOGIN_BUTTON).click();

    await expect(page.locator(LOGIN_FORM.LOGIN_FORM)).toBeVisible();

    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);
    expect(page.url()).toBe(TEST_URL.TEST_CATALOG_URL);
});

test("Verify user email is visible after user login", async ({ page }) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await expect(page.locator(LOGIN_FORM.LOGIN_FORM)).toBeVisible();
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);
    expect(page.url()).toBe(TEST_URL.TEST_CATALOG_URL);

    await expect(page.locator(LOGGED_NAVBAR.USER_EMAIL)).toBeVisible();
    await expect(page.locator(LOGGED_NAVBAR.MY_BOOKS)).toBeVisible();
    await expect(page.locator(LOGGED_NAVBAR.ADD_BOOK)).toBeVisible();
});


//Login form test

test('Login with valid credentials', async ({ page }) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);
    expect(page.url()).toBe(TEST_URL.TEST_CATALOG_URL);
});

test('Login with empty input fields', async ({ page }) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    page.on('dialog', async dialog => {
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain(ALERT.ALERT_MESSAGE);
        await dialog.accept();
    });

    await page.waitForURL(TEST_URL.TEST_LOGIN_URL);
    expect(page.url()).toBe(TEST_URL.TEST_LOGIN_URL);
});

test('Login with empty email field', async ({ page }) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    page.on('dialog', async dialog => {
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain(ALERT.ALERT_MESSAGE);
        await dialog.accept();
    });

    await page.waitForURL(TEST_URL.TEST_LOGIN_URL);
    expect(page.url()).toBe(TEST_URL.TEST_LOGIN_URL);
});

test('Login with empty password field', async ({ page }) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    page.on('dialog', async dialog => {
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain(ALERT.ALERT_MESSAGE);
        await dialog.accept();
    });

    await page.waitForURL(TEST_URL.TEST_LOGIN_URL);
    expect(page.url()).toBe(TEST_URL.TEST_LOGIN_URL);
});


//Register form test
// To do


// Add book page
test('Add book wtih correct data', async ({ page }) =>{
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    
    await Promise.all([
        page.locator(LOGIN_FORM.LOGIN_BUTTON).click(),
        page.waitForURL(TEST_URL.TEST_CATALOG_URL)
    ]);

    await page.locator(LOGGED_NAVBAR.ADD_BOOK).click();
    await page.locator(CREATE_FORM.TITLE).fill(TEST_BOOK.TITLE);
    await page.locator(CREATE_FORM.DESCRIPTION).fill(TEST_BOOK.DESCRIPTION);
    await page.locator(CREATE_FORM.IMAGE).fill(TEST_BOOK.IMAGE);
    await page.locator(CREATE_FORM.TYPE_OPTION).selectOption(TEST_BOOK.TEST_BOOK_OPTIONS.CLASSIC);
    await page.locator(CREATE_FORM.ADD_BOOK_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);
    expect(page.url()).toBe(TEST_URL.TEST_CATALOG_URL);
});


// All books page
test('Login and verify that all books are displayed', async({page})=>{
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);

    const booksCount = await page.locator(ALL_BOOKS_LIST).count();
    expect(booksCount).toBeGreaterThan(0);
    // expect(await allBooksElements.count()).toBeGreaterThan(0);
});

test('Login and verify that book details button works and details page is displayed', async({page})=>{
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);

    await page.locator(DETAILS_BUTTONS).first().click();
    await expect(page.locator(DETAILS_DESCRIPTION)).toBeVisible();
});


// Logout functionality
test('Verify that "Logout button is visible after login', async ({page})=> {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);

    await expect(page.locator(LOGGED_NAVBAR.LOGOUT_BUTTON)).toBeVisible();
});
    

test('Verify that "Logout" button redirects properly', async ({page}) => {
    await page.goto(TEST_URL.TEST_LOGIN_URL);
    await page.locator(LOGIN_FORM.EMAIL).fill(TEST_USER.EMAIL);
    await page.locator(LOGIN_FORM.PASSWORD).fill(TEST_USER.PASSWORD);
    await page.locator(LOGIN_FORM.LOGIN_BUTTON).click();
    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);

    await page.locator(LOGGED_NAVBAR.LOGOUT_BUTTON).click();

    await page.waitForURL(TEST_URL.TEST_CATALOG_URL);
    expect(page.url()).toBe(TEST_URL.TEST_CATALOG_URL);

    await expect(page.locator(NAVBAR.LOGIN_BUTTON)).toBeVisible();
    await expect(page.locator(LOGGED_NAVBAR.USER_EMAIL)).toBeHidden();
});