using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HyperTestDemo;

public class DriverFactory
{
    static DriverFactory()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
    }

    public static IWebDriver GetDriver(string testName, int makeSlowerFactor = 1)
    {
        string username = Environment.GetEnvironmentVariable("LT_USERNAME");
        string authkey = Environment.GetEnvironmentVariable("LT_ACCESSKEY");

        var capabilities = new ChromeOptions();
        capabilities.BrowserVersion = "97.0";
        var ltOptions = new Dictionary<string, object>();
        ltOptions.Add("user", username);
        ltOptions.Add("accessKey", authkey);
        ltOptions.Add("build", "your build name");
        ltOptions.Add("name", testName);
        ltOptions.Add("platformName", "Windows 10");
        ltOptions.Add("selenium_version", "4.0.0");
        capabilities.AddAdditionalOption("LT:Options", ltOptions);
        IWebDriver driver = new RemoteWebDriver(new Uri("https://" + username + ":" + authkey + "@hub.lambdatest.com/wd/hub"), capabilities);
        EventFiringWebDriver firedDriver = new EventFiringWebDriver(driver);
        firedDriver.FindingElement += (s, e) => Thread.Sleep(makeSlowerFactor * 500);
        firedDriver.Manage().Window.Maximize();

        return firedDriver;
    }
}
