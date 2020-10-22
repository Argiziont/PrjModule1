using System;

namespace PrjModule1
{
    public class MathSolverExeption : Exception
    {
        public MathSolverExeption(string message)
                : base(message)
        {}
    }
}
