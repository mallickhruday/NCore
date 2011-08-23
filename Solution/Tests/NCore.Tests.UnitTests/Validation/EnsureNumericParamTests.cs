using System;
using NCore.Resources;
using NCore.Validation;
using NUnit.Framework;

namespace NCore.Tests.UnitTests.Validation
{
    [TestFixture]
    public class EnsureNumericParamTests : UnitTestBase
    {
        private const string ParamName = "test";

        [Test]
        public void Param_IsLt_WhenIntIsGtLimit_ThrowsArgumentOutOfRangeException()
        {
            var limit = 42;
            var value = 43;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsLt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsLt_WhenIntIsEqualToLimit_ReturnsPassedValues()
        {
            const int limit = 42;
            const int value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsLt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsLt_WhenIntIsLtLimit_ReturnsPassedValues()
        {
            const int limit = 42;
            const int value = 41;

            var returnedValue = Ensure.Param(value, ParamName).IsLt(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsGt_WhenIntIsEqualToLimit_ThrowsArgumentOutOfRangeException()
        {
            var limit = 42;
            var value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsGt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsGt_WhenIntIsLtLimit_ThrowsArgumentOutOfRangeException()
        {
            var limit = 43;
            var value = 42;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsGt(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGt.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsGt_WhenIntIsGtLimit_ReturnsPassedValue()
        {
            const int limit = 41;
            const int value = 42;

            var returnedValue = Ensure.Param(value, ParamName).IsGt(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsLte_WhenIntIsEqualToLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 42;

            var returnedValue = Ensure.Param(value, ParamName).IsLte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsLte_WhenIntIsGtLimit_ThrowsArgumentOutOfRangeException()
        {
            var limit = 42;
            var value = 43;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsLte(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsLte.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsLte_WhenIntIsLtLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 41;

            var returnedValue = Ensure.Param(value, ParamName).IsLte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsGte_WhenIntIsEqualToLimit_ReturnsPassedValue()
        {
            const int limit = 42;
            const int value = 42;

            var returnedValue = Ensure.Param(value, ParamName).IsGte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsGte_WhenIntIsLtLimit_ThrowsArgumentOutOfRangeException()
        {
            var limit = 42;
            var value = 41;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsGte(limit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsGte.Inject(value, limit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsGte_WhenIntIsGtLimit_ReturnsPassedValue()
        {
            const int limit = 41;
            const int value = 42;

            var returnedValue = Ensure.Param(value, ParamName).IsGte(limit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsInRange_WhenIntIsOnLowerLimit_ReturnsPassedValue()
        {
            const int lowerLimit = 42;
            const int upperLimit = 50;
            const int value = lowerLimit;

            var returnedValue = Ensure.Param(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsInRange_WhenIntIsOnUpperLimit_ReturnsPassedValue()
        {
            const int lowerLimit = 42;
            const int upperLimit = 50;
            const int value = upperLimit;

            var returnedValue = Ensure.Param(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsInRange_WhenIntIsBetweenLimits_ReturnsPassedValue()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = 45;

            var returnedValue = Ensure.Param(value, ParamName).IsInRange(lowerLimit, upperLimit);

            Assert.AreEqual(ParamName, returnedValue.Name);
            Assert.AreEqual(value, returnedValue.Value);
        }

        [Test]
        public void Param_IsInRange_WhenIntIsLowerThanLowerLimit_ThrowsArgumentOutOfRangeException()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = lowerLimit - 1;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsInRange(lowerLimit, upperLimit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsInRange_ToLow.Inject(value, lowerLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }

        [Test]
        public void Param_IsInRange_WhenIntIsGreaterThanUpperLimit_ThrowsArgumentOutOfRangeException()
        {
            const int lowerLimit = 40;
            const int upperLimit = 50;
            const int value = upperLimit + 1;

            var ex = Assert.Throws<ArgumentException>(
                () => Ensure.Param(value, ParamName).IsInRange(lowerLimit, upperLimit));

            Assert.AreEqual(ParamName, ex.ParamName);
            Assert.AreEqual(ExceptionMessages.EnsureExtensions_IsInRange_ToHigh.Inject(value, upperLimit)
                + "\r\nParameter name: test",
                ex.Message);
        }
    }
}