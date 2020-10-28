
using System;
using System.Collections.Generic;
using Xunit;

namespace PrjModule1.Tests
{
    public class MathSolverTest
    {


        #region snippet_GetSumSin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetSumSin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetSumSin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumSin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetSumSin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetSumSin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetSumSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetSumSin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetSumSin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetSumSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetSumSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray =null;

            // Act
            void result() => MathSolver.GetSumSin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumSin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetSumSin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetSumSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumSin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetSumSin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetSumSin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumSin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetSumSin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetSumSin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_GetSumCosin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetSumCosin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetSumCosin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetSumCosin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetSumCosin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetSumCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetSumCosin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetSumCosin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetSumCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetSumCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray = null;

            // Act
            void result() => MathSolver.GetSumCosin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetSumCosin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetSumCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetSumCosin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetSumCosin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetSumCosin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetSumCosin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetSumCosin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        
        #region snippet_GetDifferenceSin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetDifferenceSin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetDifferenceSin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetDifferenceSin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetDifferenceSin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetDifferenceSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetDifferenceSin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetDifferenceSin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetDifferenceSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetDifferenceSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray =null;

            // Act
            void result() => MathSolver.GetDifferenceSin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetDifferenceSin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetDifferenceSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetDifferenceSin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetDifferenceSin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceSin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetDifferenceSin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetDifferenceSin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_GetDifferenceCosin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetDifferenceCosin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetDifferenceCosin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetDifferenceCosin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetDifferenceCosin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetDifferenceCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetDifferenceCosin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetDifferenceCosin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetDifferenceCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetDifferenceCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray = null;

            // Act
            void result() => MathSolver.GetDifferenceCosin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetDifferenceCosin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetDifferenceCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetDifferenceCosin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetDifferenceCosin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetDifferenceCosin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetDifferenceCosin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetDifferenceCosin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
       
        #region snippet_GetProductSin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetProductSin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetProductSin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductSin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetProductSin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetProductSin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetProductSin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetProductSin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetProductSin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetProductSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetProductSin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray =null;

            // Act
            void result() => MathSolver.GetProductSin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductSin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetProductSin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetProductSin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductSin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetProductSin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetProductSin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductSin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetProductSin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetProductSin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_GetProductCosin_ReturnsDouble_InputIsArrayOfDegrees
        [Fact]
        public void GetProductCosin_ReturnsDouble_InputIsArrayOfDegrees()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetProductCosin(angleArrayDegrees, 2);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ReturnsDouble_InputIsArrayOfRadians
        [Fact]
        public void GetProductCosin_ReturnsDouble_InputIsArrayOfRadians()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.GetProductCosin(angleArrayRadians, 1);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam
        [Fact]
        public void GetProductCosin_ReturnsDouble_InputIsArrayOfDegreesWithRoundParam()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            var result = MathSolver.GetProductCosin(angleArrayDegrees, 2, 5);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetProductCosin_ReturnsDouble_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetProductCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect
        [Fact]
        public void GetProductCosin_ThrowsExeption_InputIsArrayOfRadiansIsIncorrect()
        {
            // Arrange
            double[] falseAngleArray = null;

            // Act
            void result() => MathSolver.GetProductCosin(falseAngleArray, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ThrowsExeption_InputIsNullArray
        [Fact]
        public void GetProductCosin_ThrowsExeption_InputIsNullArray()
        {
            // Arrange
            double[] falseAngleArrayRadians = { 0.48f, -0.8f, -0.99, 7 };

            // Act
            void result() => MathSolver.GetProductCosin(falseAngleArrayRadians, 2, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ThrowsExeption_InputTypeIsIncorrect
        [Fact]
        public void GetProductCosin_ThrowsExeption_InputTypeIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.GetProductCosin(angleArrayRadians, 5, 5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_GetProductCosin_ThrowsExeption_InputRoundIsIncorrect
        [Fact]
        public void GetProductCosin_ThrowsExeption_InputRoundIsIncorrect()
        {
            // Arrange
            double[] angleArrayDegrees = { 100, 70, 280, 126 };

            // Act
            void result() => MathSolver.GetProductCosin(angleArrayDegrees, 2, -5);

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

        #region snippet_InvokeGetMethod_InvokesMethod_IfInputIscorrect
        [Fact]
        public void InvokeGetMethod_InvokesMethod_IfInputIscorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            var result = MathSolver.InvokeGetMethod(nameof(MathSolver.GetSumSin), new List<object> { angleArrayRadians, 1 });

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_InvokeGetMethod_ThrowsExeption_IfNameOfMethodIsIncorrect
        [Fact]
        public void InvokeGetMethod_ThrowsExeption_IfNameOfMethodIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = { 0.48f, -0.8f, -0.99 };

            // Act
            void result() => MathSolver.InvokeGetMethod("Test", new List<object> { angleArrayRadians, 1 });

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion
        #region snippet_InvokeGetMethod_ThrowsExeption_IfParamsOfMethodIsIncorrect
        [Fact]
        public void InvokeGetMethod_ThrowsExeption_IfParamsOfMethodIsIncorrect()
        {
            // Arrange
            double[] angleArrayRadians = null;

            // Act
            void result() => MathSolver.InvokeGetMethod(nameof(MathSolver.GetSumSin), new List<object>{angleArrayRadians});

            // Assert
            Assert.Throws<MathSolverExeption>(result);
        }
        #endregion

    }
}
