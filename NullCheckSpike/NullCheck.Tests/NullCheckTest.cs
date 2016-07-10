using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullCheck.Tests
{
    [TestClass]
    public class NullCheckTest
    {
        [TestMethod]
        public void PersonIsNull()
        {
            // Arrange
            NullCheck nullCheck = new NullCheck();
            Person person = null;

            // Act
            bool version1 = nullCheck.PerformNullCheckVersion1(person);
            bool version2 = nullCheck.PerformNullCheckVersion2(person);

            // Assert
            Assert.IsFalse(version1);
            Assert.IsFalse(version2);
        }

        [TestMethod]
        public void PersonIsNotNullHeadIsNull()
        {
            // Arrange
            var nullCheck = new NullCheck();
            var person = new Person();

            // Act
            bool version1 = nullCheck.PerformNullCheckVersion1(person);
            bool version2 = nullCheck.PerformNullCheckVersion2(person);

            // Assert
            Assert.IsFalse(version1);
            Assert.IsFalse(version2);
        }

        [TestMethod]
        public void PersonIsNotNullHeadIsNotNullNoseIsNull()
        {
            // Arrange
            var nullCheck = new NullCheck();
            var person = new Person
            {
                Head = new Head()
            };

            // Act
            bool version1 = nullCheck.PerformNullCheckVersion1(person);
            bool version2 = nullCheck.PerformNullCheckVersion2(person);

            // Assert
            Assert.IsFalse(version1);
            Assert.IsFalse(version2);
        }

        [TestMethod]
        public void PersonIsNotNullHeadIsNotNullNoseIsNotNull()
        {
            // Arrange
            var nullCheck = new NullCheck();
            var person = new Person
            {
                Head = new Head
                {
                    Nose = new Nose()
                }
            };

            // Act
            bool version1 = nullCheck.PerformNullCheckVersion1(person);
            bool version2 = nullCheck.PerformNullCheckVersion2(person);

            // Assert
            Assert.IsTrue(version1);
            Assert.IsTrue(version2);
            Assert.AreEqual(version1, version2);
        }
    }
}