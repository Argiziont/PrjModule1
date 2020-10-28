using System;
using System.Collections.Generic;

namespace PrjModule1
{
    class Programs
    {
        static void Main()
        {
            //Dot in console
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //

            //Ask user what he want to do
            Console.WriteLine("Select the method of providing the source data \n" +
                "Press 1- for manual\n" +
                "Press 2- for random");

            ConsoleKeyInfo method = Console.ReadKey();

            Console.Clear();

            if (method.KeyChar != '1' && method.KeyChar != '2')//If answer is incorrect 
            {
                ConsoleWithColor("\bThere no method with given code!\n", ConsoleColor.Red);
                return;
            }

            //Ask write list of methods
            Console.WriteLine("You choose method : " + method.KeyChar + "\n");
            Console.WriteLine("Methods list: \n");

            Dictionary<int, string> methodsDictionary = ShowMethods(typeof(MathSolver));

            foreach (KeyValuePair<int, string> methodValue in methodsDictionary)
            {
                Console.WriteLine(methodValue.Key + " - " + methodValue.Value);
            }
            //Ask user what he want to do
            Console.Write("\nPress function Id: ");

            int chooseFunctionId = Convert.ToInt32(char.GetNumericValue(Console.ReadKey().KeyChar));


            if (!methodsDictionary.ContainsKey(chooseFunctionId))
            {
                ConsoleWithColor("There no function with given code!\n", ConsoleColor.Red);
                return;
            }

            Console.Write("\nYou function name : ");
            ConsoleWithColor(methodsDictionary[chooseFunctionId] + "\n", ConsoleColor.Green);

            if (method.KeyChar == '1')//we choose manul values
            {
                double[] anglesParam;
                Console.Write("\bAngle list, enter a value with a space: ");
                try
                {
                    anglesParam = MathSolver.StringLineToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    ConsoleWithColor($"{ex.Message}\n", ConsoleColor.Red);
                    return;
                }

                Console.Write("\nThe type of values entered(1- radians,2- degrees): ");
                int anglesType = Convert.ToInt32(char.GetNumericValue(Console.ReadKey().KeyChar));

                if (anglesType != 1 && anglesType != 2)
                {
                    ConsoleWithColor("\b\nThere no function with given code!\n", ConsoleColor.Red);
                    return;
                }

                Console.Write("\b\n\nNumber of decimal digits(0 means 2 digit): ");
                int anglesRound = Convert.ToInt32(char.GetNumericValue(Console.ReadKey().KeyChar));

                if (anglesRound < 0 || anglesRound > 10)
                {
                    ConsoleWithColor("\bIncorrect input!\n", ConsoleColor.Red);
                    return;
                }

                try
                {
                    if (anglesRound == 0)
                    {
                        Console.WriteLine("\nAnswer is: " + MathSolver.InvokeGetMethod(methodsDictionary[chooseFunctionId], new List<object> { anglesParam, anglesType }));
                    }
                    else
                    {
                        Console.WriteLine("\nAnswer is: " + MathSolver.InvokeGetMethod(methodsDictionary[chooseFunctionId], new List<object> { anglesParam, anglesType, anglesRound }));
                    }
                }
                catch (MathSolverExeption ex)
                {
                    ConsoleWithColor($"\n{ex.Message}\n", ConsoleColor.Red);
                    return;
                }
            }
            else if (method.KeyChar == '2')//we random manul values
            {
                List<double> anglesParam = new List<double>();
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {

                    if (rnd.NextDouble() >= 0.5)
                    {
                        anglesParam.Add(rnd.NextDouble() * -1);
                    }
                    anglesParam.Add(rnd.NextDouble());
                }
                Console.Write("Random angles(in radian): ");
                foreach (double angle in anglesParam)
                {
                    Console.Write($" {Math.Round(angle, 2)}");
                }

                try
                {
                    Console.WriteLine("\nAnswer is: " + MathSolver.InvokeGetMethod(methodsDictionary[chooseFunctionId], new List<object> { anglesParam.ToArray(), 1, rnd.Next(2, 10) }));
                }
                catch (MathSolverExeption ex)
                {
                    ConsoleWithColor($"\n{ex.Message}\n", ConsoleColor.Red);
                    return;
                }
            }
        }

        private static Dictionary<int, string> ShowMethods(Type type)
        {
            Dictionary<int, string> methodsForChose = new Dictionary<int, string>();
            List<string> methods = new List<string> { "GetType", "ToString", "Equals", "GetHashCode", "InvokeGetMethod", "StringLineToDouble" };//Excluded methods

            int itter = 0;
            if (type.GetMethods().Length == 0)
            {
                throw new Exception("Incorrect type");
            }
            foreach (var method in type.GetMethods())
            {
                if (!methods.Contains(method.Name))
                {
                    // Console.WriteLine(method.Name);
                    methods.Add(method.Name);
                    methodsForChose.Add(itter, method.Name);
                    itter++;
                }
            }
            return methodsForChose;
        } 

        private static void ConsoleWithColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

    }
}
