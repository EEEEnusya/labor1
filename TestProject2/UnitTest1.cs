using Task2;
namespace TestProject2
{
    public class Tests
    {
        Rectangle rec = new(1, 3);
        Rectangle r = new(1, 7);
        Rectangle r2 = new(1, 9);
        Rectangle r3 = new(1, 10);
        [SetUp]
        public void Setup()
        {
            Rectangle rec = new(1, 3);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(rec.AreaCalculator(), 3);
            Assert.AreEqual(r.AreaCalculator(), 7);
            Assert.AreEqual(r2.PerimetrCalculator(), 20);
            Assert.AreEqual(r3.PerimetrCalculator(), 22);
        }
    }
}
