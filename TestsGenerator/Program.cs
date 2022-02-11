﻿using System.IO;
using System.Text;

namespace TestsGenerator;

public class Program
{
    public static void Main(string[] args)
    {
        var numberOfTestFiles = 10;
        var numberOfTests = 100;
        var deployLocation = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\\..\\..\\..\\..\\HyperTestDemo\\";
        ////System.Console.WriteLine(deployLocation);
        for (var i = 1; i <= numberOfTestFiles; i++)
        {
            var sb = new StringBuilder();
            sb.AppendLine("namespace HyperTestDemo;");
            sb.AppendLine("[TestFixture]");
            sb.AppendLine($"public class CheckoutPage{i}Tests");
            sb.AppendLine("{");
            for (var j = 0; j < numberOfTests; j++)
            {
                sb.AppendLine("    [Test]");
                sb.AppendLine($"   public void SuccessfullyPruchaseItem{j}()");
                sb.AppendLine("    {");
                sb.AppendLine($"        using var driver = DriverFactory.GetDriver(TestContext.CurrentContext.Test.FullName, {j + 3});");
                sb.AppendLine("        driver.Navigate().GoToUrl(\"https://getbootstrap.com/docs/4.0/examples/checkout/\");");
                sb.AppendLine("        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));");
                sb.AppendLine("        wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));");
                sb.AppendLine("        wait.Until(d => d.FindElement(By.Id(\"firstName\")) != null);");
                sb.AppendLine("        var firstName = driver.FindElement(By.Id(\"firstName\"));");
                sb.AppendLine("        firstName.SendKeys(\"Anton\");");
                sb.AppendLine("        var lastName = driver.FindElement(By.Id(\"lastName\"));");
                sb.AppendLine("        lastName.SendKeys(\"Angelov\");");
                sb.AppendLine("        var userName = driver.FindElement(By.Id(\"username\"));");
                sb.AppendLine("        userName.SendKeys(\"angelovstanton\");");
                sb.AppendLine("        var address = driver.FindElement(By.Id(\"address\"));");
                sb.AppendLine("        address.SendKeys(\"Flower Street 76\");");
                sb.AppendLine("        var email = driver.FindElement(By.Id(\"email\"));");
                sb.AppendLine("        email.SendKeys(\"george@lambdatest.com\");");
                sb.AppendLine("        var countriesSelect = new SelectElement(driver.FindElement(By.Id(\"country\")));");
                sb.AppendLine("        countriesSelect.SelectByText(\"United States\");");
                sb.AppendLine("        var statesSelect = new SelectElement(driver.FindElement(By.Id(\"state\")));");
                sb.AppendLine("        statesSelect.SelectByText(\"California\");");
                sb.AppendLine("        var zip = driver.FindElement(By.Id(\"zip\"));");
                sb.AppendLine("        zip.SendKeys(\"1000\");");
                sb.AppendLine("        var ccname = driver.FindElement(By.Id(\"cc-name\"));");
                sb.AppendLine("        ccname.SendKeys(\"Anton Angelov\");");
                sb.AppendLine("        var ccnumber = driver.FindElement(By.Id(\"cc-number\"));");
                sb.AppendLine("        ccnumber.SendKeys(\"5610591081018250\");");
                sb.AppendLine("        var ccexpiration = driver.FindElement(By.Id(\"cc-expiration\"));");
                sb.AppendLine("        ccexpiration.SendKeys(\"20/10/2020\");");
                sb.AppendLine("        var cccvv = driver.FindElement(By.Id(\"cc-cvv\"));");
                sb.AppendLine("        cccvv.SendKeys(\"888\");");
                sb.AppendLine("        var proceedButton = driver.FindElement(By.XPath(\"/html/body/div/div[2]/div[2]/form/button\"));");
                sb.AppendLine("        proceedButton.Click();");
                sb.AppendLine("    }");
            }
            sb.AppendLine("}");
            var fileLocation = Path.Combine(deployLocation, $"CheckoutPage{i}Tests.cs");
            File.WriteAllText(fileLocation, sb.ToString());
        }
    }
}
