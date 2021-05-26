using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.DTO.ExecutionResult;
using TestProject.Common.Enums;
using TestProject.SDK;

namespace DealWithAlert
{
    public class AlertRunner
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
                return runner.Run(new Alert(), true);
            }
        }
    }
}
