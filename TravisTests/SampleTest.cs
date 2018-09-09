using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravisTests {
    
    [TestClass]
    public class SampleTest {
        
        [TestMethod]
        public void ExampleTest() {
//            Assert.IsTrue(true);
            Assert.Fail("force failure to see CI fail");
        }
    }
}