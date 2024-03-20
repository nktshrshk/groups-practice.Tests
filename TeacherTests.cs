using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using groups_practice;

namespace TeacherTests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void PrintInfo_PrintsCorrectly()
        {
            // Arrange
            Teacher TestTeacher = new Teacher();
            TestTeacher.Name = "AAA";
            TestTeacher.Surname = "BBB";
            TestTeacher.Patronymic = "CCC";
            TestTeacher.Age = 20;

            using (StringWriter SW = new StringWriter())
            {
                Console.SetOut(SW);

                // Act
                TestTeacher.PrintInfo();

                // Assert
                string ExpectedOutput = $"This teacher's full name is:\nAAA BBB CCC\n\nTheir age:\n20\r\n";
                Assert.AreEqual(ExpectedOutput, SW.ToString());
            }
        }

        [TestMethod]
        public void PrintInfoForClassroom_PrintsCorrectly()
        {
            // Arrange
            Teacher TestTeacher = new Teacher();
            TestTeacher.Name = "EEE";
            TestTeacher.Surname = "FFF";
            TestTeacher.Patronymic = "GGG";

            using (StringWriter SW = new StringWriter())
            {
                Console.SetOut(SW);

                // Act
                TestTeacher.PrintInfoForClassroom();

                // Assert
                string ExpectedOutput = $"A teacher: EEE FFF GGG\r\n";
                Assert.AreEqual(ExpectedOutput, SW.ToString());
            }
        }
    }
}
