using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stayInApp = true;
            bool stayInBill = true;
            double electricityAmount;
            double internetAmount;
            double gasAmount;
            double sum = 0;

            while (stayInApp)
            {
                Console.WriteLine("1. Register customer");
                Console.WriteLine("2. Give the customer address");
                Console.WriteLine("3. Input bills");
                Console.WriteLine("x. Exit");
                Console.Write("Select 1, 2, 3 or x=Exit ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter customer name: ");
                        string customerName = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Enter customer address: ");
                        string customerAddress = Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        while (stayInBill)
                        {
                            Console.WriteLine("1. Enter the amount for elektro: ");
                            Console.WriteLine("2. Enter the amount for internet: ");
                            Console.WriteLine("3. Enter the amount for Gas: ");
                            Console.WriteLine("x. Exit");
                            Console.Write("Select 1, 2, 3 or x=Exit ");
                            string inputBill = Console.ReadLine();
                            switch (inputBill)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.Write("the amount for elektro is ");
                                    electricityAmount = double.Parse(Console.ReadLine());
                                    sum += electricityAmount;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.Write("the amount for internet is ");
                                    internetAmount = double.Parse(Console.ReadLine());
                                    sum += internetAmount;
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.Write("the amount for gas is ");
                                    gasAmount = double.Parse(Console.ReadLine());
                                    sum += gasAmount;
                                    break;
                                case "x":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"The total payed ammount is {sum}");
                                    Console.ResetColor();
                                    stayInBill = false;
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;
                    case "x":
                        stayInApp = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
