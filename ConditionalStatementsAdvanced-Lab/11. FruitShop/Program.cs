//using System;
//using System.IO;

//namespace _11._FruitShop
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string fruit = Console.ReadLine();
//            string day = Console.ReadLine();
//            double quantity = double.Parse(Console.ReadLine());
//            double price = 0;
//            switch (fruit)
//            {
//                case "banana":
//                    {
//                        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                        {
//                            price = 2.5;
//                            Console.WriteLine($"{price * quantity:F2}");
//                        }
//                        else if (day == "Saturday" || day == "Sunday")
//                        {
//                            price = 2.7;
//                            Console.WriteLine($"{price * quantity:F2}");
//                        }
//                        else { Console.WriteLine("error"); }

//                    }
//                    break;
//                case "apple":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 1.2;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 1.25;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;
//                case "orange":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 0.85;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 0.90;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;
//                case "grapefruit":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 1.45;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 1.6;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;
//                case "kiwi":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 2.7;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 3;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;
//                case "pineapple":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 5.5;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 5.6;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;
//                case "grapes":
//                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
//                    {
//                        price = 3.85;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else if (day == "Saturday" || day == "Sunday")
//                    {
//                        price = 4.2;
//                        Console.WriteLine($"{price * quantity:F2}");
//                    }
//                    else { Console.WriteLine("error"); }
//                    break;              


//                default:
//                    Console.WriteLine("error");
//                    break;
//            }

//        }
//    }
//}
using System;
namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // плод banana apple orange grapefruit kiwi pineapple grapes
            //цена 2.50 1.20 0.85 1.45 2.70 5.50 3.85
            //Събота и неделя магазинът работи на по - високи цени:
            // плод banana apple orange grapefruit kiwi pineapple grapes
            // цена 2.70 1.25 0.90 1.60 3.00 5.60 4.20
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (product == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 2.70;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.20;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.25;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 0.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 0.90;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.45;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.70;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 3.00;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 5.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 5.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (product == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 3.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if (price > 0)
            {
                double finalPrice = quantity * price;
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}