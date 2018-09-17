using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays_and_Methods___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < messageCount; i++)
            {
                string message = Console.ReadLine();
                if (message == "success")
                {
                    string operation = Console.ReadLine();
                    string messageOne = Console.ReadLine();
                    output = SuccessMessage(operation, messageOne);
                    Console.WriteLine(output);
                }
                else if (message == "error")
                {
                    string messageTwo = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    output = ErrorMessage(messageTwo, code);
                    Console.WriteLine(output);
                }
                else
                {
                    continue;
                }
            }
        }
        public static string ErrorMessage(string operation, int code)
        {
            string reason = "Invalid Client Data";
            if (code < 0)
            {
                reason = "Internal System Failure";
            }
            string output = $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.";
            return output;
        }
        public static string SuccessMessage(string operation, string messageOne)
        {
            string output = $@"Successfully executed {operation}.
==============================
Message: {messageOne}.";
            return output;
        }
    }
}
