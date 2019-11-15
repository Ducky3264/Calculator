using System;
namespace CalculatorSpace
{
    public class Calculator
    {
        private double Value1;
        private double Value2;
        protected double Ret;
        public void SetValF(int Val1, int Val2)
        {
            Value1 = Val1;
            Value2 = Val2;
        }
        public void SetVal()
        {
            string str;
            string str2;
            Calculator obj1 = new Calculator();
            Console.Write("Enter your first number.");
            str = Console.ReadLine();
            int num = Int32.Parse(str);
            Console.Write("Enter your second number.");
            str2 = Console.ReadLine();
            int num2 = Int32.Parse(str2);
            Value1 = num;
            Value2 = num2;
        }
        public double Add()
        {
            Ret = Value1 + Value2;
            return Ret;
        }
        public double Multiply()
        {
            Ret = Value1 * Value2;
            return Ret;
        }
        public double Divide()
        {
            Ret = Value1 / Value2;
            return Ret;
        }
        public double Subtract()
        {
            Ret = Value1 - Value2;
            return Ret;
        }
        public void Display(string Parg)
        {
            String Ch;
            if (Parg != "")
            {
                Ch = Parg;
            }
            else
            {
                Console.WriteLine("What operation would you like to perform? Add, Multiply, Divide, or Subtract. (Case sensitive)");
                Ch = Console.ReadLine();
            }
                if (Ch == "Add")
                {
                    Console.WriteLine("Value: {0}", Add());
                }
                else if (Ch == "Multiply")
                {
                    Console.WriteLine("Value: {0}", Multiply());
                }
                else if (Ch == "Divide")
                {
                    Console.WriteLine("Value: {0}", Divide());
                }
                else if (Ch == "Subtract")
                {
                    Console.WriteLine("Value: {0}", Subtract());
                }
                else
                {
                    Console.WriteLine("I didn't understand.");
                }
            
        }
    }
    public class Execute
    {

        static void Main(string[] args)
        {
            Calculator obj1 = new Calculator();
            int[] arrayNum = new int[2];
            bool isNumeric;
            int i = -1;
            foreach (string command in args)
            {
                isNumeric = int.TryParse(command, out int n);
                if (command == "-f")
                {
                    string argS = command;
                } else if (isNumeric == true)
                {
                  i = i + 1;
                    arrayNum[i] = n;
                    if (i == 1)
                    { 
                        obj1.SetValF((int) arrayNum.GetValue(0), (int) arrayNum.GetValue(1));
                        obj1.Display(args[3]);
                        
                    }
                } 
            }
            if (args.Length == 0)
            {
                obj1.SetVal();
                obj1.Display("");
                string in1;
                Console.Write("Would you like to quit? y/n");
                in1 = Console.ReadLine();
                if (in1 == "y")
                {

                }
                else
                {
                    Main(args);
                }
            }        
        }
    }
}





//Console.WriteLine("Printed {1} to {0}", i.ToString(), n.ToString());
//Console.WriteLine("Array pos {0} is {1}", i.ToString(), arrayNum.GetValue(0));