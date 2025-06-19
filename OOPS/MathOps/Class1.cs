using System;


namespace MathOps
{
    public class Classic
    {
        private int _OperandOne = 0;
        private int _OperandTwo = 0;

        public int OperandOne
        {
            get
            {
                return _OperandOne;
            }
            set
            {
                _OperandOne = value;
            }
        }

        public int OperandTwo
        {
            get
            {
                return _OperandTwo;
            }
            set
            {
                _OperandTwo = value;
            }
        }

        public static int Add(int OperandOne, int OperandTwo)
        {
            return OperandOne + OperandTwo;
        }

        public static int Subtract(int OperandOne, int OperandTwo)
        {
            return OperandOne - OperandTwo;
        }

        public static int Multiply(int OperandOne, int OperandTwo)
        {
            return OperandOne * OperandTwo;
        }

        public static int? Division(int OperandOne, int OperandTwo)
        {
            if (OperandTwo == 0)
            {
                return null;
            }
            else
            {
                return OperandOne / OperandTwo;
            }
        }

    }


    //    public class Complex : Classic
    //    {
    //        public override int Add(int OperandOne, int OperandTwo)
    //        {
    //            return base.Add(OperandOne,OperandTwo);
    //        }
    //        public override int Subtract(int OperandOne, int OperandTwo)
    //        {
    //            return base.Subtract(OperandOne, OperandTwo); ;
    //        }

    //        public override int Multiply(int OperandOne, int OperandTwo)
    //        {
    //            return base.Multiply(OperandOne, OperandTwo); ;
    //        }
    //        public override int? Division(int OperandOne, int OperandTwo)
    //        {
    //            return base.Division(OperandOne, OperandTwo);
    //        }

    //        public int Power(int OperandOne, int OperandTwo)
    //        {

    //            int ipower = 1;
    //            for (int i = 0; i < OperandTwo; i++)
    //            {
    //                ipower = ipower * OperandOne;

    //            }
    //            return ipower;
    //        }

    //        public float Root(int OperandOne, int OperandTwo)
    //        {
    //           float root=(float)Math.Pow(OperandOne,(1.0/OperandTwo));
    //            return root;
    //        }
    //    }
    //}

    public class Complex
    {
        private int _OperandOne = 0;
        private int _OperandTwo = 0;

        public int OperandOne
        {
            get
            {
                return _OperandOne;
            }
            set
            {
                _OperandOne = value;
            }
        }

        public int OperandTwo
        {
            get
            {
                return _OperandTwo;
            }
            set
            {
                _OperandTwo = value;
            }
        }

        public static int Add(int OperandOne, int OperandTwo)
        {
            return OperandOne + OperandTwo;
        }

        public static int Subtract(int OperandOne, int OperandTwo)
        {
            return OperandOne - OperandTwo;
        }

        public static int Multiply(int OperandOne, int OperandTwo)
        {
            return OperandOne * OperandTwo;
        }

        public static int? Division(int OperandOne, int OperandTwo)
        {
            if (OperandTwo == 0)
            {
                return null;
            }
            else
            {
                return OperandOne / OperandTwo;
            }
        }
        public static int Power(int OperandOne, int OperandTwo)
        {

            int ipower = 1;
            for (int i = 0; i < OperandTwo; i++)
            {
                ipower = ipower * OperandOne;

            }
            return ipower;
        }

        public static Decimal Root(int OperandOne, int OperandTwo)
        {


            return Convert.ToDecimal(Math.Pow(OperandOne, 1.0 / OperandTwo));

        }
    }
}

                    