using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlConversions;

namespace ConversionTests
{
    [TestClass]
    public class SQLConversion
    {
        [TestMethod]
        public void SQLConversionTest()
        {
            Assert.AreEqual("1", 1.SqlCastAs<string>());
            Assert.AreEqual(null, DBNull.Value.SqlCastAs<string>());

            string test = null;
            Assert.AreEqual(null, test.SqlCastAs<string>());

            test = null;
            Assert.AreEqual(null, test.SqlTryCastAs<string>());

            Assert.AreEqual("1", 1.SqlTryCastAs<string>());
            Assert.AreEqual(null, DBNull.Value.SqlTryCastAs<string>());
            Assert.AreEqual("string", DBNull.Value.SqlTryCastAs<string>("string"));

            Assert.AreEqual(1, 1.SqlTryCastAs<int?>());
            Assert.AreEqual(null, DBNull.Value.SqlTryCastAs<int?>());
            Assert.AreEqual(1, DBNull.Value.SqlTryCastAs<int>(1));




        }
    }
}
