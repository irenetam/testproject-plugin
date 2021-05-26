using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Attributes;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;

namespace Auth_Basic
{
    public class AuthBasic : IWebTest
    {
        [ParameterAttribute(Description = "Auto generate application URL parameter", DefaultValue = "http://the-internet.herokuapp.com/", Direction = TestProject.Common.Enums.ParameterDirection.Input)]
        public string ApplicationURL;
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;
            var report = helper.Reporter;
            string url = "http://admin:admin@the-internet.herokuapp.com/basic_auth";

            var boolResult = driver.TestProject().NavigateToURL(url);
            report.Step(string.Format("Navigate to '{0}'", url), boolResult, TestProject.Common.Enums.TakeScreenshotConditionType.Failure);

            return ExecutionResult.Passed;
        }
    }
}
