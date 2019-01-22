using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev_3.Test
{
    [TestClass]
    public class NumberSystemConversionTests
    {
        [TestMethod]
        [DataRow (0,"0",2)]
        [DataRow(0, "0", 3)]
        [DataRow(0, "0", 4)]
        [DataRow(0, "0", 5)]
        [DataRow(0, "0", 6)]
        [DataRow(0, "0", 7)]
        [DataRow(0, "0", 8)]
        [DataRow(0, "0", 9)]
        [DataRow(0, "0", 10)]
        [DataRow(0, "0", 11)]
        [DataRow(0, "0", 12)]
        [DataRow(0, "0", 13)]
        [DataRow(0, "0", 14)]
        [DataRow(0, "0", 15)]
        [DataRow(0, "0", 16)]
        [DataRow(0, "0", 17)]
        [DataRow(0, "0", 18)]
        [DataRow(0, "0", 19)]
        [DataRow(0, "0", 20)]
        public void ZeroToOtherNumberSystem(int argument, string expected , int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, "1", 2)]
        [DataRow(1, "1", 3)]
        [DataRow(1, "1", 4)]
        [DataRow(1, "1", 5)]
        [DataRow(1, "1", 6)]
        [DataRow(1, "1", 7)]
        [DataRow(1, "1", 8)]
        [DataRow(1, "1", 9)]
        [DataRow(1, "1", 10)]
        [DataRow(1, "1", 11)]
        [DataRow(1, "1", 12)]
        [DataRow(1, "1", 13)]
        [DataRow(1, "1", 14)]
        [DataRow(1, "1", 15)]
        [DataRow(1, "1", 16)]
        [DataRow(1, "1", 17)]
        [DataRow(1, "1", 18)]
        [DataRow(1, "1", 19)]
        [DataRow(1, "1", 20)]
        public void OneToOtherNumberSystem(int argument, string expected, int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(50, "110010", 2)]
        [DataRow(50, "1212", 3)]
        [DataRow(50, "302", 4)]
        [DataRow(50, "200", 5)]
        [DataRow(50, "122", 6)]
        [DataRow(50, "101", 7)]
        [DataRow(50, "62", 8)]
        [DataRow(50, "55", 9)]
        [DataRow(50, "50", 10)]
        [DataRow(50, "46", 11)]
        [DataRow(50, "42", 12)]
        [DataRow(50, "3B", 13)]
        [DataRow(50, "38", 14)]
        [DataRow(50, "35", 15)]
        [DataRow(50, "32", 16)]
        [DataRow(50, "2G", 17)]
        [DataRow(50, "2E", 18)]
        [DataRow(50, "2C", 19)]
        [DataRow(50, "2A", 20)]
        public void FiftyToOtherNumberSystem(int argument, string expected, int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(-1, "-1", 2)]
        [DataRow(-1, "-1", 3)]
        [DataRow(-1, "-1", 4)]
        [DataRow(-1, "-1", 5)]
        [DataRow(-1, "-1", 6)]
        [DataRow(-1, "-1", 7)]
        [DataRow(-1, "-1", 8)]
        [DataRow(-1, "-1", 9)]
        [DataRow(-1, "-1", 10)]
        [DataRow(-1, "-1", 11)]
        [DataRow(-1, "-1", 12)]
        [DataRow(-1, "-1", 13)]
        [DataRow(-1, "-1", 14)]
        [DataRow(-1, "-1", 15)]
        [DataRow(-1, "-1", 16)]
        [DataRow(-1, "-1", 17)]
        [DataRow(-1, "-1", 18)]
        [DataRow(-1, "-1", 19)]
        [DataRow(-1, "-1", 20)]
        public void MinusOneToOtherNumberSystem(int argument, string expected, int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow('a', 12)]
        [DataRow("ABC",2)]
        [DataRow((double)2.3,16)]
        [DataRow((float)2.3, 16)]
        [DataRow(false, 16)]
        public void NotNumberAsArgument (int argument, int newBase)
        {
            //arrange
            string actual = string.Empty;
            System.Exception actualException = null;
            //act
            try
            {
                Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
                actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            } catch (System.Exception ex)
            {
                actualException = ex;
            }
            //assert
            Assert.IsNull(actualException);
        }

        [TestMethod]
        [DataRow(int.MinValue, "-10000000000000000000000000000000", 2)]
        [DataRow(int.MinValue, "-12112122212110202102", 3)]
        [DataRow(int.MinValue, "-2000000000000000", 4)]
        [DataRow(int.MinValue, "-13344223434043", 5)]
        [DataRow(int.MinValue, "-553032005532", 6)]
        [DataRow(int.MinValue, "-104134211162", 7)]
        [DataRow(int.MinValue, "-20000000000", 8)]
        [DataRow(int.MinValue, "-5478773672", 9)]
        [DataRow(int.MinValue, "-2147483648", 10)]
        [DataRow(int.MinValue, "-A02220282", 11)]
        [DataRow(int.MinValue, "-4BB2308A8", 12)]
        [DataRow(int.MinValue, "-282BA4AAB", 13)]
        [DataRow(int.MinValue, "-1652CA932", 14)]
        [DataRow(int.MinValue, "-C87E66B8", 15)]
        [DataRow(int.MinValue, "-80000000", 16)]
        [DataRow(int.MinValue, "-53G7F549", 17)]
        [DataRow(int.MinValue, "-3928G3H2", 18)]
        [DataRow(int.MinValue, "-27C57H33", 19)]
        [DataRow(int.MinValue, "-1DB1F928", 20)]
        public void MinimalIntegerAsArgument (int argument, string expected, int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(int.MaxValue, "111111111111111111111111111111", 2)]
        [DataRow(int.MaxValue, "12112122212110202101", 3)]
        [DataRow(int.MaxValue, "1333333333333333", 4)]
        [DataRow(int.MaxValue, "13344223434042", 5)]
        [DataRow(int.MaxValue, "553032005531", 6)]
        [DataRow(int.MaxValue, "104134211161", 7)]
        [DataRow(int.MaxValue, "17777777777", 8)]
        [DataRow(int.MaxValue, "5478773671", 9)]
        [DataRow(int.MaxValue, "2147483647", 10)]
        [DataRow(int.MaxValue, "A02220281", 11)]
        [DataRow(int.MaxValue, "4BB2308A7", 12)]
        [DataRow(int.MaxValue, "282BA4AAA", 13)]
        [DataRow(int.MaxValue, "1652CA931", 14)]
        [DataRow(int.MaxValue, "C87E66B7", 15)]
        [DataRow(int.MaxValue, "7FFFFFFF", 16)]
        [DataRow(int.MaxValue, "53G7F548", 17)]
        [DataRow(int.MaxValue, "3928G3H1", 18)]
        [DataRow(int.MaxValue, "27C57H32", 19)]
        [DataRow(int.MaxValue, "1DB1F927", 20)]
        public void MaximumIntegerAsArgument(int argument, string expected, int newBase)
        {
            //arrange
            string actual = string.Empty;
            //act
            Dev_3.NumberSystemConversion numberSystemConversion = new Dev_3.NumberSystemConversion(newBase);
            actual = numberSystemConversion.ConvertIntToNewSystem(argument);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
