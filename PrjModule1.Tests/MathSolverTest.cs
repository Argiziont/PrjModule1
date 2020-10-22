
using System;
using System.Collections.Generic;
using Xunit;

namespace PrjModule1.Tests
{
    public class MathSolverTest
    {
        #region snippet_GetSumSin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetSumSin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99,7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126,370 };


            // Act
            var resultOne = MathSolver.GetSumSin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetSumSin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetSumSin(angleArrayDegrees, 2,5);
            MathSolverExeption resultFour=null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetSumSin(falseAngleArrayRadians, 2,5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetSumSin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetSumSin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }
            
            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_GetSumCosin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetSumCosin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126, 370 };


            // Act
            var resultOne = MathSolver.GetSumCosin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetSumCosin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetSumCosin(angleArrayDegrees, 2, 5);
            MathSolverExeption resultFour = null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetSumCosin(falseAngleArrayRadians, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetSumCosin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetSumCosin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }

            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_GetDifferenceSin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetDifferenceSin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126, 370 };


            // Act
            var resultOne = MathSolver.GetDifferenceSin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetDifferenceSin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetDifferenceSin(angleArrayDegrees, 2, 5);
            MathSolverExeption resultFour = null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetDifferenceSin(falseAngleArrayRadians, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetDifferenceSin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetDifferenceSin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }

            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_GetDifferenceCosin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetDifferenceCosin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126, 370 };


            // Act
            var resultOne = MathSolver.GetDifferenceCosin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetDifferenceCosin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetDifferenceCosin(angleArrayDegrees, 2, 5);
            MathSolverExeption resultFour = null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetDifferenceCosin(falseAngleArrayRadians, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetDifferenceCosin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetDifferenceCosin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }

            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_GetProductSin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetProductSin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126, 370 };


            // Act
            var resultOne = MathSolver.GetProductSin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetProductSin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetProductSin(angleArrayDegrees, 2, 5);
            MathSolverExeption resultFour = null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetProductSin(falseAngleArrayRadians, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetProductSin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetProductSin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }

            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_GetProductCosin_ReturnsDouble_IfInputIscorrect
        [Fact]
        public void GetProductCosin_ReturnsDouble_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };
            double[] angleArrayDegrees = { 100, 70, 280, 126 };
            double[] falseAngleArrayDegrees = { 100, 70, 280, 126, 370 };


            // Act
            var resultOne = MathSolver.GetProductCosin(angleArrayRadians, 1);
            var resultTwo = MathSolver.GetProductCosin(angleArrayDegrees, 2);
            var resultThree = MathSolver.GetProductCosin(angleArrayDegrees, 2, 5);
            MathSolverExeption resultFour = null;
            MathSolverExeption resultFive = null;
            MathSolverExeption resultSix = null;
            try
            {
                MathSolver.GetProductCosin(falseAngleArrayRadians, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultFour = ex;
            }
            try
            {
                MathSolver.GetProductCosin(falseAngleArrayDegrees, 1);
            }
            catch (MathSolverExeption ex)
            {
                resultFive = ex;
            }
            try
            {
                MathSolver.GetProductCosin(null, 2, 5);
            }
            catch (MathSolverExeption ex)
            {
                resultSix = ex;
            }

            // Assert
            _ = Assert.IsType<double>(resultOne);
            _ = Assert.IsType<double>(resultTwo);
            _ = Assert.IsType<double>(resultThree);
            Assert.True(resultFour.Message.Length > 0);
            Assert.True(resultFive.Message.Length > 0);
            Assert.True(resultSix.Message.Length > 0);


        }
        #endregion
        #region snippet_InvokeGetMethod_InvokesMethod_IfInputIscorrect
        [Fact]
        public void InvokeGetMethod_InvokesMethod_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };



            // Act
            var resultOne = MathSolver.InvokeGetMethod(nameof(MathSolver.GetSumSin), new List<object> { angleArrayRadians,1 });

            Exception resultwo = null;
            Exception resulthree = null;

            try
            {
                MathSolver.InvokeGetMethod("Test", new List<object> { angleArrayRadians, 1 });
            }
            catch (Exception ex)
            {

                resultwo=ex;
            }
            try
            {
                MathSolver.InvokeGetMethod(nameof(MathSolver.GetSumSin), null);
            }
            catch (Exception ex)
            {

                resulthree = ex;
            }
            // Assert
            _ = Assert.IsType<double>(resultOne);

            Assert.True(resultwo.Message.Length > 0);
            Assert.True(resulthree.Message.Length > 0);
        }
        #endregion
    }
}
