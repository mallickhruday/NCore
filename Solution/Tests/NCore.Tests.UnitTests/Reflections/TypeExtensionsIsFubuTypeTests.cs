using System;
using NCore.Reflections;
using NUnit.Framework;

namespace NCore.Tests.UnitTests.Reflections
{
    [TestFixture]
    public class TypeExtensionsIsFubuTypeTests : UnitTestBase
    {
        [Test]
        public void IsStringType_WhenStringType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(string).IsStringType());
        }

        [Test]
        public void IsStringType_WhenNotStringType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsStringType());
        }

        [Test]
        public void IsDateTimeType_WhenDateTimeType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(DateTime).IsDateTimeType());
        }

        [Test]
        public void IsDateTimeType_WhenNotDateTimeType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsDateTimeType());
        }

        [Test]
        public void IsBoolType_WhenBoolType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(bool).IsBoolType());
        }

        [Test]
        public void IsBoolType_WhenNotBoolType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsBoolType());
        }

        [Test]
        public void IsDecimalType_WhenDecimalType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(decimal).IsDecimalType());
        }

        [Test]
        public void IsDecimalType_WhenNotDecimalType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsDecimalType());
        }

        [Test]
        public void IsSinlgeType_WhenSingleType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(Single).IsSingleType());
        }

        [Test]
        public void IsSinlgeType_WhenNotSingleType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsSingleType());
        }

        [Test]
        public void IsFloatType_WhenFloatType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(float).IsFloatType());
        }

        [Test]
        public void IsFloatType_WhenNotFloatType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsFloatType());
        }

        [Test]
        public void IsDoubleType_WhenDoubleType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(double).IsDoubleType());
        }

        [Test]
        public void IsDoubleType_WhenNotDoubleType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsDoubleType());
        }

        [Test]
        public void IsLongType_WhenLongType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(long).IsLongType());
        }

        [Test]
        public void IsLongType_WhenNotLongType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsLongType());
        }

        [Test]
        public void IsGuidType_WhenGuidType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(Guid).IsGuidType());
        }

        [Test]
        public void IsGuidType_WhenNotGuidType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsGuidType());
        }

        [Test]
        public void IsIntType_WhenIntType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(int).IsIntType());
        }

        [Test]
        public void IsIntType_WhenNotIntType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(bool).IsIntType());
        }

        [Test]
        public void IsShortType_WhenShortType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(short).IsShortType());
        }

        [Test]
        public void IsShortType_WhenNotShortType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsShortType());
        }

        [Test]
        public void IsCharType_WhenCharType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(char).IsCharType());
        }

        [Test]
        public void IsCharType_WhenNotCharType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsCharType());
        }

        [Test]
        public void IsEnumType_WhenEnumType_ReturnsTrue()
        {
            Assert.IsTrue(typeof(GCCollectionMode).IsEnumType());
        }

        [Test]
        public void IsEnumType_WhenNotEnumType_ReturnsFalse()
        {
            Assert.IsFalse(typeof(int).IsEnumType());
        }
    }
}