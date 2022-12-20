namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
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

                matrix = new int[5, 4]
                {
                {1, 11, 3 , 4 },
                {1, 2, 3 , 3 },
                {4, 21, 3 , 4 },
                {1, 2, 6, 4 },
                {1, 2, 3 ,4 }
                };
            }


            [TestMethod]
            public void GetMaxRow()
            {
                int max = 32;

                int maxRow = mat.GetMaxRow(matrix);

                Assert.AreEqual(maxRow, max);
            }

            [TestMethod]
            public void GetNotEven()
            {
                int even = 2;

                int evenRow = mat.GetNotEven(matrix);

                Assert.AreEqual(evenRow, even);
            }

            [TestMethod]
            public void GetNegative()
            {
                int negative = 0;

                int negativeRow = mat.GetNegative(matrix);

                Assert.AreEqual(negativeRow, negative);
            }

            [TestMethod]
            public void SumOfElements()
            {
                int sum = 83;

                int sumElement = mat.SumOfElements(matrix);

                Assert.AreEqual(sum, sumElement);
            }

            [TestMethod]
            public void CheckMatrixZero()
            {
                int zero = 0;

                int zeroMatrix = mat.CheckMatrixZero(matrix);

                Assert.AreEqual(zeroMatrix, zero);
            }
        }
    }
}


