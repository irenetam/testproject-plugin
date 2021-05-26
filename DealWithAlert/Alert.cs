using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Attributes;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;

namespace DealWithAlert
{
    public class Alert : IWebTest
    {
        [ParameterAttribute(Description = "Auto generate application URL parameter", DefaultValue = "http://the-internet.herokuapp.com/", Direction = TestProject.Common.Enums.ParameterDirection.Input)]
        public string ApplicationURL;

        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;
            var report = helper.Reporter;
            bool boolResult;
            By by;

            //1. Navigate to URL
            // Navigates the specified URL (Auto-generated)
            boolResult = driver.TestProject().NavigateToURL(ApplicationURL);
            report.Step(string.Format("Navigate to '{0}'", ApplicationURL), boolResult, TestProject.Common.Enums.TakeScreenshotConditionType.Failure);

            //2. Click 'JavaScript Alerts'
            by = By.XPath("//*[text()='JavaScript Alerts']");
            boolResult = driver.TestProject().Click(by);
            report.Step("Click 'JavaScript Alerts'", boolResult, TestProject.Common.Enums.TakeScreenshotConditionType.Failure);

            //3. Click 'Click for JS Alert'
            by = By.XPath("//*[text()='Click for JS Alert']");
            boolResult = driver.TestProject().Click(by);
            report.Step("Click Click for JS Alert'", boolResult, TestProject.Common.Enums.TakeScreenshotConditionType.Failure);

            //4. Check Alert is present
            var alert = driver.SwitchTo().Alert();
            alert.Accept();

            return ExecutionResult.Passed;
        }
    }
}
