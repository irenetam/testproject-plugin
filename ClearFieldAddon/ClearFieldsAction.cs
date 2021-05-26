using OpenQA.Selenium;
using System;
using System.Linq;
using TestProject.Common.Attributes;
using TestProject.SDK;
using TestProject.SDK.Addons.Actions;
using TestProject.SDK.Addons.Helpers;

namespace ClearFieldAddon
{
    [Action(Name = "Clear Fields of me")]
    public class ClearFieldsAction : IWebAction
    {
        public ExecutionResult Execute(WebAddonHelper helper)
        {
            //var driver = helper.Driver;
            //IWebElement searchField = driver.FindElement(By.Id("userName"));
            //if (!searchField.Displayed)
            //{
            //    helper.Reporter.Result = "No input field was found with the id: s";
            //    return ExecutionResult.Failed;
            //}
            //searchField.Clear();
            //searchField.SendKeys("ToolsQA");
            //return ExecutionResult.Passed;


            var driver = helper.Driver;
            foreach (IWebElement form in driver.FindElements(By.TagName("form")))
            {
                if (!form.Displayed)
                {
                    continue;
                }
                var inputElements = form.FindElements(By.XPath("//input[not(@type='checkbox')]"));
                foreach (IWebElement element in inputElements)
                {
                    element.Clear();
                }
            }
            return ExecutionResult.Passed;
        }
    }
}
