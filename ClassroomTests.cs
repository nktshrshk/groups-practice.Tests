using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using groups_practice;

namespace ClassroomTests
{
    [TestClass]
    public class ClassroomTests
    {
        [TestMethod]
        public void PrintInfo_PrintsCorrectly()
        {
            // Arrange
            Classroom TestClassroom = new Classroom();
            TestClassroom.Name = "TestClassroom1";
            TestClassroom.Teacher = new Teacher { Name = "Test", Surname = "Teacher", Patronymic = "1", Age = 20 };
            TestClassroom.Student = new Student { Name = "Test", Surname = "Student", Patronymic = "1", Age = 200 };

            using (StringWriter SW = new StringWriter())
            {
                Console.SetOut(SW);

                // Act
                TestClassroom.PrintInfo();

                // Assert
                string ExpectedOutput = $"This is TestClassroom1 classroom. It contains:\r\n";
                ExpectedOutput += $"A teacher: Test Teacher 1\r\n";
                ExpectedOutput += $"A student: Test Student 1\r\n";
                Assert.AreEqual(ExpectedOutput, SW.ToString());
            }
        }
    }
}
