namespace TestNUnit
{
    public class Tests
    {
        private int[,] matrix;

        private MyMatrix mat;
        [SetUp]
        public void Setup()
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

        [Test]
        public void GeMaxRow()
        {
            int max = 32;

            int maxRow = mat.GetMaxRow(matrix);

            Assert.AreEqual(maxRow, max);
        }

        [Test]
        public void GetEven()
        {
            int even = 2;

            int evenRow = mat.GetNotEven(matrix);

            Assert.AreEqual(evenRow, even);
        }


        [Test]    
        public void GetNegative()
        {
            int negative = 0;

            int negativeRow = mat.GetNegative(matrix);

            Assert.AreEqual(negativeRow, negative);
        }

        [Test]
        public void SumOfElements()
        {
            int sum = 83;

            int sumElement = mat.SumOfElements(matrix);

            Assert.AreEqual(sum, sumElement);
        }

        [Test]
        public void CheckMatrixZero()
        {
            int zero = 0;

            int zeroMatrix = mat.CheckMatrixZero(matrix);

            Assert.AreEqual(zeroMatrix, zero);
        }
    }
}