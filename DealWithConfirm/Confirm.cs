using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Attributes;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Drivers;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using TestProject.Common.Enums;

namespace DealWithConfirm
{
    public class Confirm : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;
            var report = helper.Reporter;
            bool boolResult;
            By by;

            // 4. Click 'JavaScript Alerts'
            // Add step sleep time (Before)
            Thread.Sleep(500);
            by = By.XPath("//a[. = 'JavaScript Alerts']");
            boolResult = driver.TestProject().Click(by);
            report.Step("Click 'JavaScript Alerts'", boolResult, TakeScreenshotConditionType.Failure);

            // 5. Click 'Click for JS Confirm'
            // Add step sleep time (Before)
            Thread.Sleep(500);
            by = By.XPath("//button[. = 'Click for JS Confirm']");
            boolResult = driver.TestProject().Click(by);
            report.Step("Click 'Click for JS Confirm'", boolResult, TakeScreenshotConditionType.Failure);

            // Check Alert is present
            IsAlertPresentAndCorrect(driver, "Ok");

            return ExecutionResult.Passed;
        }

        private bool IsAlertPresentAndCorrect(WebDriver driver, string message)
        {
            try
            {
                string alertText = driver.SwitchTo().Alert().Text;
                driver.SwitchTo().Alert().Accept();
                return alertText.Equals(message);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
