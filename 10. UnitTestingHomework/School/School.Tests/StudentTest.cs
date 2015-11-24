namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        private Student student;

        [TestInitialize]
        public void InitializeStudent()
        {
            this.student = new Student("Pitar", 11111);
        }

        [TestMethod]
        public void StudentShouldReturnNameFromTheConstructor()
        {
            Assert.AreEqual("Pitar", this.student.Name, "Student name is not valid");
        }

        [TestMethod]
        public void StudentShouldReturnIdFromTheConstructor()
        {
            Assert.AreEqual(11111, this.student.Id, "Student id is not valid");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullStudentNameShouldThrowArgumentException()
        {
            this.student = new Student(" ", 23233);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStudentNameShouldThrowArgumentNullException()
        {
            this.student = new Student(null, 23233);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdHighOutOfRangeShouldThrowOutOfRangeException()
        {
            this.student = new Student("Joro", 232333);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdLowOutOfRangeShouldThrowOutOfRangeException()
        {
            this.student = new Student("Joro", 111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentJoiningNullCourseShouldThrowArgumentNullException()
        {
            Course course = null;

            this.student.JoinCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentLeaveingNullCourseShouldThrowArgumentNullException()
        {
            Course course = null;

            this.student.LeaveCourse(course);
        }

        [TestMethod]
        public void StudentProperlyJoinsCourse()
        {
            Course course = new Course("math");
            student.JoinCourse(course);

            Assert.IsTrue(course.Students.Contains(student), "Student is not added to course");
        }

        [TestMethod]
        public void StudentProperlyLeavesCourse()
        {
            Course course = new Course("math");
            student.JoinCourse(course);
            student.LeaveCourse(course);

            Assert.IsFalse(course.Students.Contains(student), "Student is still in the course");
        }
    }
}
