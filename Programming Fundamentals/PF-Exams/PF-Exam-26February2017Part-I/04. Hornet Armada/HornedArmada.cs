namespace _04.Hornet_Armada
{
    using System;
    public class HornedArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());



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
