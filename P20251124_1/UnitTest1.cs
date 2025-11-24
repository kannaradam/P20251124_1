using NUnit.Framework.Legacy;

namespace P20251124_1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int x=0; 
            int y=0;
        }

        [Test]
        public void Test1()
        {
            int x = 5;
            string szoveg = "premontrei";
            ClassicAssert.NotZero(x);
        }
    }
}
