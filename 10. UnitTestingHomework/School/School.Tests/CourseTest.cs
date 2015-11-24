namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        private Course course;

        [TestInitialize]
        public void InitializeCourse()
        {
            this.course = new Course("JagaScript");
        }

        [TestMethod]
        public void CourseShouldNotThrowException()
        {
            course = new Course("HQC");
        }

        [TestMethod]
        public void CourseShouldReturnName()
        {
            string name = course.Name;
            Assert.AreEqual("JagaScript", name, "Created Course does not return correct name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseWithNullNameShouldThrowException()
        {
            course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseWithEmptyNameShouldThrowException()
        {
            course = new Course(" ");
        }

        [TestMethod]
        public void CourseShouldAddStudentsCorrectly()
        {
            Student student = new Student("Petkan", 50000);

            course.AddStudent(student);
            int numberOfStudents = course.Students.Count;

            Assert.AreEqual(1, numberOfStudents, "Course cannot add students correctly");
        }

        [TestMethod]
        public void CourseShouldRemoveStudentsCorrectly()
        {
            Student student = new Student("Petkan", 50000);

            course.AddStudent(student);
            course.RemoveStudent(student);
            int numberOfStudents = course.Students.Count;

            Assert.AreEqual(0, numberOfStudents, "Course cannot remove students correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullStudentToCourseShouldThrowArgumentNullException()
        {
            Student student = null;

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullStudentToCourseShouldThrowArgumentNullException()
        {
            Student student = null;

            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldHaveLessThanThirthyStudents()
        {
            for (int i = 0; i < 30; i++)
            {
                Student student = new Student("Ivan", 10000 + i);
                this.course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddingExistingStudentShouldThrowArgumentException()
        {
            Student student = new Student("Pesho", 12121);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingUnexistingStudentShouldThrowArgumentException()
        {
            Student student = new Student("Pesho", 12121);

            course.RemoveStudent(student);
        }
    }
}
