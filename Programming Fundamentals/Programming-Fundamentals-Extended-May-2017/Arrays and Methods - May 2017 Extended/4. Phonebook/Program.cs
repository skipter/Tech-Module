using System;
using System.Linq;
namespace _4.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] phoneNames = Console.ReadLine().Split();
            string[] inputNames = Console.ReadLine().Split();
            while (inputNames[0] != "done")
            {
                if (inputNames[0] == "call")
                {
                    for (int cnt = 0; cnt < phoneNames.Length; cnt++)
                    {
                        if (inputNames[1] == phoneNames[cnt])
                        {
                            Console.WriteLine($"calling {phoneNumbers[cnt]}...");
                            string phoneNum = phoneNumbers[cnt];
                            int digitsSum = GetDigitsSum(phoneNum);
                            if (digitsSum % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = digitsSum / 60;
                                int seconds = digitsSum % 60;
                                Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                            }
                        }
                        if (inputNames[1] == phoneNumbers[cnt])
                        {
                            Console.WriteLine($"calling {phoneNames[cnt]}...");
                            string phoneNum = phoneNumbers[cnt];
                            int digitsSum = GetDigitsSum(phoneNum);
                            if (digitsSum % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = digitsSum / 60;
                                int seconds = digitsSum % 60;
                                Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                            }
                        }
                    }
                }

                if (inputNames[0] == "message")
                {
                    for (int cnt = 0; cnt < phoneNames.Length; cnt++)
                    {
                        if (inputNames[1] == phoneNames[cnt])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[cnt]}...");
                            string phoneNum = phoneNumbers[cnt];
                            int phoneNumSum = GetDigitsSum(phoneNum);
                            if (phoneNumSum % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                        if (inputNames[1] == phoneNumbers[cnt])
                        {
                            Console.WriteLine($"sending sms to {phoneNames[cnt]}...");
                            string phoneNum = phoneNames[cnt];
                            int phoneNumSum = GetDigitsSum(phoneNum);
                            if (phoneNumSum % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                    }
                    inputNames = Console.ReadLine().Split();
                }
            }
        }
        private static int GetDigitsSum(string phoneNumbera)
        {
            int getPhoneNumberSum = 0;
            for (int indexCounter = 0; indexCounter < phoneNumbera.Length; indexCounter++)
            {
                if (phoneNumbera[indexCounter] >= 48 && phoneNumbera[indexCounter] <= 57)
                {
                    getPhoneNumberSum += ((int)phoneNumbera[indexCounter] - 48);
                }
            }
            return getPhoneNumberSum;
        }
    }
}







