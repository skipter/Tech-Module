namespace _04.Hornet_Armada
{
    using System;
    using System.Collections.Generic;

    public class HornedArmada
    {
        public static void Main()
        {                                               //TODO
            int n = int.Parse(Console.ReadLine());
                    
            Dictionary<string, Dictionary<string, long>> soldier = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine()
                    .Split(new string[] { " -> ", " ", "=", "-", ":", }, StringSplitOptions.RemoveEmptyEntries);

                string lastActivity = inputData[0];
                string legionName = inputData[1];
                string soldierType = inputData[2];
                string soldierCount = inputData[3];         //Input tested
                
            }   
        }
    }
}
