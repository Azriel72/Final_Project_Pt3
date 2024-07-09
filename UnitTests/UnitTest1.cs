using MyWebApplication1;
using MyWebApplication1.Controllers;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetWords1()
        {
            string input = "hola,ss,holass";
            var result = new Search_Word();
            var output = result.GetWords(input);
            var expectedResult = new List<string>() { "holass" };
            Assert.IsTrue(expectedResult.SequenceEqual(output));
        }

        [TestMethod]
        public void GetWords2()
        {
            string input = "es,taan,estaan";
            var result = new Search_Word();
            var output = result.GetWords(input);
            var expectedResult = new List<string>() { "estaan" };
            Assert.IsTrue(expectedResult.SequenceEqual(output));
        }
    }
}