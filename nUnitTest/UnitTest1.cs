using NUnit.Framework;
using WorkWithMatrixLib;

namespace nUnitTest
{
    public class Tests
    {
        private int[,] matrix;
        private MyMatrix myMatrix;

        [SetUp]
        public void Setup()
        {
            myMatrix = new MyMatrix();

            matrix = new int[4, 4]
            {
                {1, 11, 3 ,4 },
                {1, 2, 3 ,3 },
                {4, 21, 3 ,4 },
                {1, 2, 6,4 }
            };
        }

        [Test]
        public void GetMaxBelowDioganal()
        {
            int max = 21;

            int maxMatrix = myMatrix.GetMaxBelowDioganal(matrix);

            Assert.AreEqual(maxMatrix, max);
        }

        [Test]
        public void GetAverageMeanMaxMinBelowDiagonal()
        {
            int value = 11;

            int GetAverageMeanMaxMin = myMatrix.GetAverageMeanMaxMinBelowDiagonal(matrix);

            Assert.AreEqual(GetAverageMeanMaxMin, value);

        }

        [Test]
        public void ReduceElementsOfTheSideDiagonal()
        {
            int[,] newMatrix = myMatrix.ReduceElementsOfTheSideDiagonal(matrix,
                myMatrix.GetAverageMeanMaxMinBelowDiagonal(matrix));

            CollectionAssert.AreEqual(newMatrix, matrix);

        }


        [Test]
        public void IsMatrixSquare()
        {
            Assert.IsTrue(myMatrix.IsMatrixSquare(matrix));
        }
    }
}