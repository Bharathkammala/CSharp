using System;
using MathOps;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Console Calculator\n");

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
            Console.WriteLine("Please Select an option to Perform");
            Console.WriteLine("1 : Classic");
            Console.WriteLine("2 : Complex");
            Console.WriteLine("0 : Exit");
            int iOpOne = Convert.ToInt32(Console.ReadLine());
            return iOpOne;

        }

        public static void ClassicMenu()
        {
            int iop2=0;

            do
            {

                Console.WriteLine("\n1 : Add");
                Console.WriteLine("2 : Subtract");
                Console.WriteLine("3 : Multiply");
                Console.WriteLine("4 : Division");
                Console.WriteLine("0 : Exit");
                iop2 = Convert.ToInt32(Console.ReadLine());

                if(iop2 == (int)(ClassicOption.Exit))
                {
                    break;

                }

                Console.Write("Enter your First Number : ");
                int iNumOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your Second Number :");
                int iNumTwo = Convert.ToInt32(Console.ReadLine());

                switch (iop2)
                {
                    case (int)ClassicOption.Add:
                        Console.WriteLine("Result = "+Classic.Add(iNumOne, iNumTwo));
                        break;
                    case (int)(ClassicOption.Subtract):
                        Console.WriteLine("Result = "+Classic.Subtract(iNumOne, iNumTwo));
                        break;
                    case (int)(ClassicOption.Multiply):
                        Console.WriteLine("Result = " + Classic.Multiply(iNumOne, iNumTwo));
                        break;
                    case (int)(ClassicOption.Divide):
                        Console.WriteLine("Result = " + Classic.Division(iNumOne, iNumTwo));
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (iop2 != 0);
        }
       

        public static void ComplexMenu()
        {

            int iop3=0;
            do
            {
                Console.WriteLine("\n1 Add");
                Console.WriteLine("2 Subtract");
                Console.WriteLine("3 Multiply");
                Console.WriteLine("4 Division");
                Console.WriteLine("5 Power");
                Console.WriteLine("6 Root");
                Console.WriteLine("0");
                iop3 = Convert.ToInt32(Console.ReadLine());

                if(iop3 == (int)ComplexOption.Exit)
                {
                    break;
                }
                Console.WriteLine("Enter your First Number : ");
                int iNumOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Second Number : ");
                int iNumTwo = Convert.ToInt32(Console.ReadLine());

                switch (iop3)
                {
                    case (int)ComplexOption.Add:
                        Console.WriteLine("Result = " + Complex.Add(iNumOne, iNumTwo));
                        break;
                    case (int)(ComplexOption.Subtract):
                        Console.WriteLine("Result = " + Complex.Subtract(iNumOne, iNumTwo));
                        break;
                    case (int)(ComplexOption.Multiply):
                        Console.WriteLine("Result = " + Classic.Multiply(iNumOne, iNumTwo));
                        break;
                    case (int)(ComplexOption.Divide):
                        Console.WriteLine("Result = " + Complex.Division(iNumOne, iNumTwo));
                        break;
                    case (int)ComplexOption.Power:
                        Console.WriteLine("Result = " + Complex.Power(iNumOne, iNumTwo));
                        break;

                    case (int)ComplexOption.Root:
                        Console.WriteLine("Result = " + Complex.Root(iNumOne, iNumTwo));
                        break;

                    default:
                        Console.WriteLine("Invalid Operation\n");
                        break;


                }
            }while(iop3 != 0);
        }

    }
}
