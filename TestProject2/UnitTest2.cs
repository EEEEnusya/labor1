using Task3;
namespace TestProject2
{
    public class Tests1
    {
       private Point x = null!;
        private Point y = null!;
        private Point z = null!;
        private Figure One = null!;
       
        [SetUp]
        public void Setup()
        {
             x = new Point(1, 0);
             y = new Point(1, 1);
             z = new Point(1, 0);
             One = new Figure(x, y, z);
        }

        [Test]
        public void Test1()
        {
           Assert.AreEqual(One.PerimetrMnogougol(),2);
        }
    }
}