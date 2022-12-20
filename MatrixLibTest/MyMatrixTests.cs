using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkWithMatrixLib;

namespace MatrixLibTest
{
    [TestClass]
    public class MyMatrixTests
    {
        private int[,] matrix;

        private MyMatrix mat;

        [TestInitialize]
        public void InitializeMatrix()
        {
            mat = new MyMatrix();

            matrix = new int[4, 4]
            {
                {1, 11, 3 ,4 },
                {1, 2, 3 ,3 },
                {4, 21, 3 ,4 },
                {1, 2, 6,4 }
            };
        }


        [TestMethod]
        public void GetMinBelowDioganal()
        {
            int min = 1;

            int minMatrix = mat.GetMinBelowDioganal(matrix);

            Assert.AreEqual(minMatrix, min);
        }

        [TestMethod]
        public void GetMaxBelowDioganal()
        {
            int max = 21;

            int maxMatrix = mat.GetMaxBelowDioganal(matrix);

            Assert.AreEqual(maxMatrix, max);
        }

        [TestMethod]
        public void GetAverageMeanMaxMinBelowDiagonal()
        {
            int value = 11;

            int GetAverageMeanMaxMin = mat.GetAverageMeanMaxMinBelowDiagonal(matrix);

            Assert.AreEqual(GetAverageMeanMaxMin, value);

        }

        [TestMethod]
        public void ReduceElementsOfTheSideDiagonal()
        {
            int [,] newMatrix = mat.ReduceElementsOfTheSideDiagonal(matrix, 
                mat.GetAverageMeanMaxMinBelowDiagonal(matrix));
            
            CollectionAssert.AreEqual(newMatrix, matrix);

        }


        [TestMethod]
        public void IsMatrixSquare()
        {
            Assert.IsTrue(mat.IsMatrixSquare(matrix));
        }
    }
}
