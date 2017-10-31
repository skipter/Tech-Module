namespace _02.Command_Intrepreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CommandIntrepreter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var commands = Console.ReadLine();
            while (commands != "end")
            {
                if (commands.Contains("reverse"))
                {

                }
                if (commands.Contains("sort"))
                {

                }
                if (commands.Contains("rollLeft"))
                {

                }
                if (commands.Contains("rollRight"))
                {

                }





                commands = Console.ReadLine();
            }
        }
    }
}
