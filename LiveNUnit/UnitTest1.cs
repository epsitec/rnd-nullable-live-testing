using NUnit.Framework;

namespace LiveNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var x = new LiveLib.Class1 ();
            x.Get<string> ("x"); // LIVE UNIT TESTING FAIL

            /*
             C:\git\rnd\LiveTesting\LiveLib\Class1.cs(7,17): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
             C:\git\rnd\LiveTesting\LiveLib\Class1.cs(7,16): error CS8627: A nullable type parameter must be known to be a value type or non-nullable reference type. Consider adding a 'class', 'struct', or type constraint.
            */
        }
    }
}
