using OpenQA.Selenium;
using System;
using TestProject.Common.DTO.ExecutionResult;
using TestProject.Common.Enums;
using TestProject.SDK;

namespace ClearFieldAddon
{
    public class ClearFieldRunner
    {
        public static string DevToken = "sxahhYWu9pWoNhWCV_rC45KdqMDBMJ04wajhUdL4wCo";
        public static AutomatedBrowserType Browser = AutomatedBrowserType.Chrome;
        static void Main(string[] args)
        {
            try
            {
                RunAlert();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static StepExecutionResult RunAlert()
        {
            using (var runner = new RunnerBuilder(DevToken).AsWeb(Browser).Build())
            {
                //var box = new ClearFieldsAction();
                //IWebDriver driver = (IWebDriver)runner.GetDriver();
                //driver.Navigate().GoToUrl("https://demoqa.com/text-box");
                //return runner.Run(box, true);

                var box = new ClearFieldsAction();
                IWebDriver driver = (IWebDriver)runner.GetDriver();
                driver.Navigate().GoToUrl("http://vn-devint:4000/login");
                return runner.Run(box, true);
            }
        }
    }
}
