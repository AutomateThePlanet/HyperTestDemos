using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HyperTestDemo
{
    [TestFixture]
    public class CheckoutPage1Tests
    {
        [Test]
        public void SuccessfullyPruchaseItem0()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 3);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem1()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 4);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem2()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 5);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem3()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 6);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem4()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 7);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem5()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 8);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem6()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 9);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem7()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 10);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem8()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 11);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem9()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 12);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem10()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 13);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem11()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 14);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem12()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 15);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem13()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 16);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem14()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 17);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem15()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 18);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem16()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 19);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem17()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 20);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem18()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 21);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem19()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 22);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem20()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 23);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem21()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 24);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem22()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 25);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem23()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 26);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem24()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 27);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem25()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 28);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem26()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 29);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem27()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 30);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem28()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 31);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem29()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 32);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem30()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 33);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem31()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 34);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem32()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 35);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem33()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 36);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem34()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 37);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem35()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 38);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem36()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 39);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem37()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 40);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem38()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 41);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem39()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 42);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem40()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 43);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem41()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 44);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem42()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 45);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem43()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 46);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem44()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 47);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem45()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 48);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem46()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 49);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem47()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 50);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem48()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 51);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem49()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 52);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem50()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 53);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem51()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 54);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem52()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 55);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem53()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 56);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem54()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 57);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem55()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 58);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem56()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 59);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem57()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 60);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem58()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 61);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem59()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 62);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem60()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 63);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem61()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 64);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem62()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 65);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem63()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 66);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem64()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 67);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem65()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 68);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem66()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 69);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem67()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 70);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem68()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 71);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem69()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 72);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem70()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 73);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem71()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 74);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem72()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 75);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem73()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 76);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem74()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 77);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem75()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 78);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem76()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 79);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem77()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 80);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem78()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 81);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem79()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 82);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem80()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 83);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem81()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 84);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem82()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 85);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem83()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 86);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem84()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 87);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem85()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 88);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem86()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 89);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem87()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 90);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem88()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 91);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem89()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 92);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem90()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 93);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem91()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 94);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem92()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 95);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem93()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 96);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem94()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 97);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem95()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 98);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem96()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 99);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem97()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 100);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem98()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 101);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
        [Test]
        public void SuccessfullyPruchaseItem99()
        {
            using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, 102);
            driver.Navigate().GoToUrl("https://getbootstrap.com/docs/4.0/examples/checkout/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(d => d.FindElement(By.Id("firstName")) != null);
            var firstName = driver.FindElement(By.Id("firstName"));
            firstName.SendKeys("Anton");
            var lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Angelov");
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("angelovstanton");
            var address = driver.FindElement(By.Id("address"));
            address.SendKeys("Flower Street 76");
            var email = driver.FindElement(By.Id("email"));
            email.SendKeys("george@lambdatest.com");
            var countriesSelect = new SelectElement(driver.FindElement(By.Id("country")));
            countriesSelect.SelectByText("United States");
            var statesSelect = new SelectElement(driver.FindElement(By.Id("state")));
            statesSelect.SelectByText("California");
            var zip = driver.FindElement(By.Id("zip"));
            zip.SendKeys("1000");
            var ccname = driver.FindElement(By.Id("cc-name"));
            ccname.SendKeys("Anton Angelov");
            var ccnumber = driver.FindElement(By.Id("cc-number"));
            ccnumber.SendKeys("5610591081018250");
            var ccexpiration = driver.FindElement(By.Id("cc-expiration"));
            ccexpiration.SendKeys("20/10/2020");
            var cccvv = driver.FindElement(By.Id("cc-cvv"));
            cccvv.SendKeys("888");
            var proceedButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/form/button"));
            proceedButton.Click();
        }
    }
}