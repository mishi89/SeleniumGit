namespace SeleniumGit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("++++++++++++++++Test Setup++++++++++++++++");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}