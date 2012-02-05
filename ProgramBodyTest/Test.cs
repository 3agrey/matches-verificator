using System;
using Ppc.GeneratePassword;
using NUnit.Framework;

namespace ProgramBodyTest
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void Test_Zero_Password ()
		{
			string actual = RandomChars.Generate(0);
            Assert.AreEqual(0, actual.Length, "testing for 1 symbol password failed");
		}
		
		[Test()]
		public void Test_Password_Eq1 ()
		{
			string actual = RandomChars.Generate(1);
            Assert.AreEqual(1, actual.Length, "testing for 1 symbol password failed");
		}
		
		[Test()]
		public void Test_Password_Eq15 ()
		{
			string actual = RandomChars.Generate(15);
            Assert.AreEqual(15, actual.Length, "testing for 15 symbol password failed");
		}
		
		[Test()]
		public void Test_Password_Eq1024 ()
		{
			string actual = RandomChars.Generate(1024);
            Assert.AreEqual(1024, actual.Length, "testing for 1024 symbol password failed");
		}

        [Test()]
        public void Test_Bad_Param ()
        {
            string actual = RandomChars.Generate(-1);
            Assert.AreNotEqual(-1, actual.Length, "length should not be less than zero");
            Assert.AreEqual(0, actual.Length, "actual length should be 0");
        }
	}
}

