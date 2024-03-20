using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using groups_practice;

namespace StudentTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void PrintInfo_PrintsCorrectly()
        {
            // Arrange
            Student TestStudent = new Student();
            TestStudent.Name = "AAA";
            TestStudent.Surname = "BBB";
            TestStudent.Patronymic = "CCC";
            TestStudent.Age = 10;

            using (StringWriter SW = new StringWriter())
            {
                Console.SetOut(SW);

                // Act
                TestStudent.PrintInfo();

                // Assert
                string ExpectedOutput = $"This student's full name is:\nAAA BBB CCC\n\nTheir age:\n10\r\n";
                Assert.AreEqual(ExpectedOutput, SW.ToString());
            }
        }

        [TestMethod]
        public void PrintInfoForClassroom_PrintsCorrectly()
        {
            // Arrange
            Student TestStudent = new Student();
            TestStudent.Name = "DDD";
            TestStudent.Surname = "EEE";
            TestStudent.Patronymic = "FFF";

            using (StringWriter SW = new StringWriter())
            {
                Console.SetOut(SW);

                // Act
                TestStudent.PrintInfoForClassroom();

                // Assert
                string ExpectedOutput = $"A student: DDD EEE FFF\r\n";
                Assert.AreEqual(ExpectedOutput, SW.ToString());
            }
        }
    }
}
