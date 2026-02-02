using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace SimpleNotes
{ 
    [TestFixture]
    public class SimpleNotesTests
    {
        protected IWebDriver driver;
        private static readonly string BaseUrl = "https://d5wfqm7y6yb3q.cloudfront.net";
        private static string? lastAddedNoteTitle;
        private static string? lastAddedNoteDescription;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--disable-search-engine-choice-screen");
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var actions = new Actions(driver);

            driver.Navigate().GoToUrl($"{BaseUrl}");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));	
            var joinButton = wait.Until(driver => driver.FindElement(By.CssSelector("a.btn.btn-outline-light.btn-lg.mt-5")));
            actions.ScrollToElement(joinButton).Perform();
            joinButton.Click();
            
            var loginButton = wait.Until(driver => driver.FindElement(By.Id("tab-login")));
            loginButton.Click();
            var usernameInput = wait.Until(driver => driver.FindElement(By.Id("loginName")));
            usernameInput.SendKeys("simrus123@email.com");
            var passwordInput = wait.Until(driver => driver.FindElement(By.Id("loginPassword")));
            passwordInput.SendKeys("simrus321");

            // driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            var signInButton = wait.Until(driver => driver.FindElement(By.CssSelector("button[type='submit']")));
            actions.ScrollToElement(signInButton).Perform();
            signInButton.Click();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [Test, Order(1)]
        public void AddNoteWithInvalidDataTest()
        {
            string invalidTitle = "";
            string invalidDescription = "";

            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");
            driver.FindElement(By.CssSelector("a.btn.btn-info")).Click();

            driver.FindElement(By.Id("form4Example1")).SendKeys(invalidTitle);
            driver.FindElement(By.Id("form4Example3")).SendKeys(invalidDescription);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            string currentUrl = driver.Url;
            Assert.That(currentUrl, Is.EqualTo($"{BaseUrl}/Note/Create"), "The page should remain on the same page with invalid data.");

            var errorMessage = driver.FindElement(By.CssSelector(".toast.toast-error"));
            Assert.IsTrue(errorMessage.Displayed, "The main error message is not displayed.");
        }

        [Test, Order(2)]
        public void AddRandomNoteTest()
        {
            lastAddedNoteTitle = "Note " + GenerateRandomString(5);
            lastAddedNoteDescription = "Description Random String number is " + GenerateRandomString(10);

            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");
            driver.FindElement(By.CssSelector("a.btn.btn-info")).Click();

            driver.FindElement(By.Id("form4Example1")).SendKeys(lastAddedNoteTitle);
            driver.FindElement(By.Id("form4Example3")).SendKeys(lastAddedNoteDescription);
            
            var selectElement = driver.FindElement(By.CssSelector("select"));
            var select = new SelectElement(selectElement);
            select.SelectByText("New");
            
            // driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            var actions = new Actions(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var createButton = wait.Until(driver => driver.FindElement(By.CssSelector("button[type='submit']")));
            actions.ScrollToElement(createButton).Perform();
            createButton.Click();
            
            var successMessage = driver.FindElement(By.CssSelector("div.toast-message"));
            Assert.That(successMessage.Text, Is.EqualTo("Note created successfully!"), "Success message text did not match.");
        }

        [Test, Order(3)]
        public void EditLastAddedNoteTitleTest()
        {
            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");
            var lastNoteSection = driver.FindElement(By.CssSelector("section.p-4.d-flex.justify-content-center.text-center.w-100"));
            var editButton = lastNoteSection.FindElement(By.CssSelector("a[href*='/Note/Edit']"));
            editButton.Click();

            var titleInput = driver.FindElement(By.Id("form4Example1"));
            var newTitle = "Updated Note Title";
            titleInput.Clear();
            titleInput.SendKeys(newTitle);

            // var saveButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            // saveButton.Click();
            var actions = new Actions(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var saveButton = wait.Until(driver => driver.FindElement(By.CssSelector("button[type='submit']")));
            actions.ScrollToElement(saveButton).Perform();
            saveButton.Click();

            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");
            var editedNote = driver.FindElement(By.CssSelector("section.p-4.d-flex.justify-content-center.text-center.w-100"));
            var editedNoteTitle = editedNote.FindElement(By.CssSelector("div.card-body h5.card-title")).Text;

            Assert.That(newTitle, Is.EqualTo(editedNoteTitle), "The title of the note does not match the expected value.");
        }

        [Test, Order(4)]
        public void MoveEditedNoteToDoneTest()
        {
            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");
            var lastNoteSection = driver.FindElement(By.CssSelector("section.p-4.d-flex.justify-content-center.text-center.w-100"));
            var changeToDoneButton = lastNoteSection.FindElement(By.CssSelector("a[href*='ChangeToDone']"));
            changeToDoneButton.Click();

            var successMessage = driver.FindElement(By.CssSelector("div.toast-message"));
            Assert.That(successMessage.Text, Is.EqualTo("Note status changed successfully!"), "Success message text did not match.");
        }

        [Test, Order(5)]
        public void DeleteLastNoteTest()
        {
            driver.Navigate().GoToUrl($"{BaseUrl}/Note/Done");

            var lastNoteSection = driver.FindElement(By.CssSelector("section.p-4.d-flex.justify-content-center.text-center.w-100"));
            var deleteButton = lastNoteSection.FindElement(By.CssSelector("a.btn.btn-danger"));
            deleteButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Title.Contains("Delete page - Simple Notes"));

            string pageTitle = driver.Title;
            Assert.That(pageTitle, Is.EqualTo("Delete page - Simple Notes"), "The page title is not correct.");

            var confirmDeleteButton = driver.FindElement(By.CssSelector("form[action*='/Note/Delete'] button[type='submit']"));
            confirmDeleteButton.Click();
        }

        [Test, Order(6)]
        public void LogoutTest()
        {
            driver.Navigate().GoToUrl($"{BaseUrl}/Home/Main");

            // var logoutButton = driver.FindElement(By.CssSelector("a[href='/User/Logout']"));
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var logoutButton = wait.Until(driver => driver.FindElement(By.CssSelector("a[href='/User/Logout']")));
            logoutButton.Click();

            string pageTitle = driver.Title;
            Assert.That(pageTitle, Is.EqualTo("Home Page - SimpleNotes.WebApp"), "The page title is not correct.");

            driver.Navigate().GoToUrl($"{BaseUrl}/Note/New");

            var accessDeniedMessage = wait.Until(driver =>
            {
                var element = driver.FindElement(By.TagName("pre"));
                return element.Displayed ? element : null;
            });

            string actualMessage = accessDeniedMessage.Text;

            Assert.That(actualMessage, Is.EqualTo("Access Denied"), "The access denied message was not displayed correctly.");
        }
    }
}