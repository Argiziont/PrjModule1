using System;

namespace PrjModule1
{
    class MathSolverExeption : Exception
    {
        public MathSolverExeption(string message)
                : base(message)
        {}
    }
}
