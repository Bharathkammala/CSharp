using System;
using MathOps;
using Operations;

namespace Math
{
    internal class Program
    {
        enum MainOption
        {
            Classic = 1,
            Complex = 2,
            Exit = 0
        }

        enum ClassicOption
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4,
            Exit = 0
        }

        enum ComplexOption
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4,
            Power = 5,
            Root = 6,
            Exit = 0
        }

        static FileOperations FileOps = new FileOperations()
        {
            FullPath = "D:\\C#\\ConsoleCalculator",
            Name = "history.txt"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Console Calculator\n");          

            /*FileOps.CreateFile();*/           //  Creating  A File To Store history

            int iChOne;

            do
            {
                iChOne = MainMenu();

                switch (iChOne)
                {
                    case (int)MainOption.Classic:
                        ClassicMenu();
                        break;
                    case (int)MainOption.Complex:
                        ComplexMenu();
                        break;
                    case (int)MainOption.Exit:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }


            } while (iChOne != 0);
        }



        public static int MainMenu()
        {
            Console.WriteLine("\nPlease Select an option to Perform");
            Console.WriteLine("1 : Classic");
            Console.WriteLine("2 : Complex");
            Console.WriteLine("0 : Exit\n");
            int iOpOne = Convert.ToInt32(Console.ReadLine());
            return iOpOne;

        }

        public static void ClassicMenu()
        {
            int iop2 = 0;

            do
            {

                Console.WriteLine("\n1 : Add");
                Console.WriteLine("2 : Subtract");
                Console.WriteLine("3 : Multiply");
                Console.WriteLine("4 : Division");
                Console.WriteLine("0 : Exit\n");
                iop2 = Convert.ToInt32(Console.ReadLine());

                if (iop2 == (int)(ClassicOption.Exit))
                {
                    break;

                }

                Console.Write("\nEnter your First Number : ");
                int iNumOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your Second Number :");
                int iNumTwo = Convert.ToInt32(Console.ReadLine());

                switch (iop2)
                {
                    case (int)ClassicOption.Add:
                        Console.WriteLine("Result = " + Classic.Add(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n{iNumOne} + {iNumTwo} = {Classic.Add(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)(ClassicOption.Subtract):
                        Console.WriteLine("Result = " + Classic.Subtract(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n{iNumOne} - {iNumTwo} = {Classic.Subtract(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)(ClassicOption.Multiply):
                        Console.WriteLine("Result = " + Classic.Multiply(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n {iNumOne} * {iNumTwo} = {Classic.Multiply(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)(ClassicOption.Divide):
                        Console.WriteLine("Result = " + Classic.Division(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n {iNumOne} / {iNumTwo} = {Classic.Division(iNumOne, iNumTwo)}\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (iop2 != 0);
        }


        public static void ComplexMenu()
        {

            int iop3 = 0;
            do
            {
                Console.WriteLine("\n1 Add");
                Console.WriteLine("2 : Subtract");
                Console.WriteLine("3 : Multiply");
                Console.WriteLine("4 : Division");
                Console.WriteLine("5 : Power");
                Console.WriteLine("6 : Root");
                Console.WriteLine("0 : Exit\n");
                iop3 = Convert.ToInt32(Console.ReadLine());

                if (iop3 == (int)ComplexOption.Exit)
                {
                    break;
                }
                Console.WriteLine("\nEnter your First Number : ");
                int iNumOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Second Number : ");
                int iNumTwo = Convert.ToInt32(Console.ReadLine());

                switch (iop3)
                {
                    case (int)ComplexOption.Add:
                        Console.WriteLine("Result = " + Complex.Add(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n{iNumOne} + {iNumTwo} = {Complex.Add(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)(ComplexOption.Subtract):
                        Console.WriteLine("Result = " + Complex.Subtract(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"{iNumOne} - {iNumTwo} = {Complex.Subtract(iNumOne, iNumTwo)} \n");
                        break;
                    case (int)(ComplexOption.Multiply):
                        Console.WriteLine("Result = " + Complex.Multiply(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n {iNumOne} * {iNumTwo} = {Complex.Multiply(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)(ComplexOption.Divide):
                        Console.WriteLine("Result = " + Complex.Division(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n {iNumOne} / {iNumTwo} = {Complex.Division(iNumOne, iNumTwo)}\n");
                        break;
                    case (int)ComplexOption.Power:
                        Console.WriteLine("Result = " + Complex.Power(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n{iNumOne} ^ {iNumTwo} = {Complex.Power(iNumOne, iNumTwo)} \n");
                        break;

                    case (int)ComplexOption.Root:
                        Console.WriteLine("Result = " + Complex.Root(iNumOne, iNumTwo));
                        FileOps.AppendToFile($"\n{iNumTwo} root of {iNumOne} = {Complex.Root(iNumOne, iNumTwo)} \n");
                        break;

                    default:
                        Console.WriteLine("Invalid Operation\n");
                        break;


                }
            } while (iop3 != 0);
        }

    }
}
