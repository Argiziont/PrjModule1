using System;
using System.Collections.Generic;
using System.Linq;


namespace PrjModule1
{
    public static class MathSolver
    {
        /// <summary>
        /// Sums the sines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <returns>The sum of the sines of the entered values</returns>
        public static double GetSumSin(double[] angles, int type)
        {
            double sum = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            sum += Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            sum += Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(sum, 2);
        }
        /// <summary>
        /// Sums the sines of the entered array with custom round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The sum of the sines of the entered values</returns>
        public static double GetSumSin(double[] angles, int type, int decimals)
        {
            double sum = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            sum += Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            sum += Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(sum, decimals);
        }
        /// <summary>
        /// Sums the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <returns>The sum of the cosines of the entered values</returns>
        public static double GetSumCosin(double[] angles, int type)
        {
            double sum = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            sum += Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            sum += Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(sum, 2);
        }
        /// <summary>
        /// Sums the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The sum of the cosines of the entered values</returns>
        public static double GetSumCosin(double[] angles, int type, int decimals)
        {
            double sum = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            sum += Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            sum += Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(sum, decimals);
        }
        /// <summary>
        /// Difference the sines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>s
        /// <returns>The difference of the sines of the entered values</returns>
        public static double GetDifferenceSin(double[] angles, int type)
        {
            double diff = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            diff -= Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            diff -= Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(diff, 2);
        }
        /// <summary>
        /// Difference the sines of the entered array with custom round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The difference of the sines of the entered values</returns>
        public static double GetDifferenceSin(double[] angles, int type, int decimals)
        {
            double diff = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            diff -= Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            diff -= Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(diff, decimals);
        }
        /// <summary>
        /// Difference the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <returns>The difference of the cosines of the entered values</returns>
        public static double GetDifferenceCosin(double[] angles, int type)
        {
            double diff = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            diff -= Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            diff -= Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(diff, 2);
        }
        /// <summary>
        /// Difference the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The difference of the sines of the entered values</returns>
        public static double GetDifferenceCosin(double[] angles, int type, int decimals)
        {
            double diff = 0;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            diff -= Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            diff -= Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(diff, decimals);
        }
        /// <summary>
        /// Product the sines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <returns>The product of the sines of the entered values</returns>
        public static double GetProductSin(double[] angles, int type)
        {
            double prod = 1;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            prod *= Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            prod *= Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(prod, 2);
        }
        /// <summary>
        /// Product the sines of the entered array with custom round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The product of the sines of the entered values</returns>
        public static double GetProductSin(double[] angles, int type, int decimals)
        {
            double prod = 1;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            prod *= Math.Sin(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The sine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            prod *= Math.Sin(angle);
                        else
                            throw new MathSolverExeption("The sine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(prod, decimals);
        }
        /// <summary>
        /// Product the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <returns>The product of the cosines of the entered values</returns>
        public static double GetProductCosin(double[] angles, int type)
        {
            double prod = 1;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            prod *= Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            prod *= Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(prod, 2);
        }
        /// <summary>
        /// Product the cosines of the entered array with default round
        /// </summary>
        /// <param name="angles">Array of angles (radians or degrees)</param>
        /// <param name="type">The type of values entered:
        /// 1- radians
        /// 2- degrees</param>
        /// <param name="decimals">The number of decimal places</param>
        /// <returns>The product of the cosines of the entered values</returns>
        public static double GetProductCosin(double[] angles, int type, int decimals)
        {
            double prod = 1;
            switch (type)
            {
                case 1:
                    foreach (double angle in angles)
                    {
                        if (angle >= -1 && angle <= 1)
                        {
                            double currentAngle = RadiansToDegrees(angle);
                            prod *= Math.Cos(currentAngle);
                        }

                        else
                            throw new MathSolverExeption("The cosine exists only for values [-1;1]");
                    }
                    break;
                case 2:
                    foreach (double angle in angles)
                    {
                        if (angle >= 0 && angle <= 360)
                            prod *= Math.Cos(angle);
                        else
                            throw new MathSolverExeption("The cosine exists only for values [0°;360°]");
                    }
                    break;
                default:
                    throw new MathSolverExeption("Entered type doesn't exist");
            }

            return Math.Round(prod, decimals);
        }
        /// <summary>
        /// Invokes method with given name
        /// </summary>
        /// <param name="methodName">Method name</param>
        /// <param name="args">Method params</param>
        public static object InvokeGetMethod(string methodName, List<object> args)
        {
            var method = typeof(MathSolver)
              .GetMethods()
              .Where(x => x.Name == methodName)
              .FirstOrDefault(x => x.GetParameters().Length == args.Count);
            
            try
            {
                return method.Invoke(null, args.ToArray());
            }
            catch (Exception ex)
            {
                throw new MathSolverExeption(ex.Message);
            }

        }
        /// <summary>
        /// Converts string line to double array if it's possible
        /// </summary>
        /// <param name="stringLine">Your string with numbers sepatated with " " </param>
        /// <returns>Array of double numbers</returns>
        public static double[] StringLineToDouble(string stringLine)
        {
            string[] stringArray = stringLine.Split(" ");
            List<double> doubleList = new List<double>();

            foreach (string item in stringArray)
            {
                try
                {
                    doubleList.Add(Convert.ToDouble(item));
                }
                catch (MathSolverExeption)
                {
                    throw new MathSolverExeption("Incorrect string input");
                }
            }
            return doubleList.ToArray();
        }
        /// <summary>
        /// Coverts Radians to degrees
        /// </summary>
        /// <param name="radians">Your number in radians</param>
        /// <returns>Degrees</returns>
        public static double RadiansToDegrees(double radians)
        {
            return (180 / Math.PI) * radians;
        }
    }
}
