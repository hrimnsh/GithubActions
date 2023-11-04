using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

       [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(-2, Program.Subtract("1", "3"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("a", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("3", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "b"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(15, Program.Multiply("5", "3"));
            Assert.AreEqual(35, Program.Multiply("7", "5"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("a", "3"));
            Assert.Throws<FormatException>(() => Program.Multiply("5", "b"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "b"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(5, Program.Divide("15", "3"));
            Assert.AreEqual(7, Program.Divide("35", "5"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("a", "3"));
            Assert.Throws<FormatException>(() => Program.Divide("15", "b"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "b"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("6", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(16, Program.Power("2", "4"));
            Assert.AreEqual(1, Program.Power("5", "0"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("a", "3"));
            Assert.Throws<FormatException>(() => Program.Power("2", "b"));
            Assert.Throws<FormatException>(() => Program.Power("a", "b"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
