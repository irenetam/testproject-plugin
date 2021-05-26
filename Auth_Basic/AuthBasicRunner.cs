using System;
using TestProject.Common.DTO.ExecutionResult;
using TestProject.Common.Enums;
using TestProject.SDK;

namespace Auth_Basic
{
    class AuthBasicRunner
    {
        public static string DevToken = "sxahhYWu9pWoNhWCV_rC45KdqMDBMJ04wajhUdL4wCo";
        public static AutomatedBrowserType Browser = AutomatedBrowserType.Chrome;
        public static StepExecutionResult RunAuthBasic()
        {
            using (var runner = new RunnerBuilder(DevToken).AsWeb(Browser).Build())
                return runner.Run(new AuthBasic(), true);
        }
        static void Main(string[] args)
        {
            try
            {
                RunAuthBasic();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
