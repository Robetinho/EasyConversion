using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conversions;

namespace ConversionTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1.TryCastAs<string>(), "1");
            Assert.AreEqual(true, 1.CanCastAs<string>());

            Assert.AreEqual(1.TryCastAs<int>(), 1);
            Assert.AreEqual(true, 1.CanCastAs<int>());

            Assert.AreEqual("123466".TryCastAs<int>(), 123466);
            Assert.AreEqual(true, "123466".CanCastAs<int>());

            Assert.AreEqual("1.1".TryCastAs<double>(), 1.1);

            Assert.AreEqual("234wgser".TryCastAs<int>(), 0);

            Assert.AreEqual(1.TryCastAs<double>(), 1.0);

            Assert.AreEqual("234wgser".TryCastAs<int?>(), null);
            Assert.AreEqual(false, "234wgser".CanCastAs<int>());

            int? a = 1;
            Assert.AreEqual(a, "1".TryCastAs<int?>());
            a = null;
            Assert.AreEqual(null, "1dfgf".TryCastAs<int?>());
            a = null;
            Assert.AreEqual(1, "1dfgf".TryCastAs<int?>(1));

            Assert.AreEqual(null, new NullReferenceException().TryCastAs<string>());
            Assert.AreEqual(false, new NullReferenceException().CanCastAs<string>());

            Assert.AreEqual("hello", new NullReferenceException().TryCastAs<string>("hello"));

            Assert.AreEqual("1", 1.TryCastAs<string>("hello"));



        }
    }
}
