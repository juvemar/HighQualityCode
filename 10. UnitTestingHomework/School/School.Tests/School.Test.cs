namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        private School school;

        [TestInitialize]
        public void InitializeSchool()
        {
            this.school = new School();
        }

        [TestMethod]
        public void SchoolShouldNotThrowException()
        {
            school = new School();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrowException()
        {
            school.AddStudent(null);
        }

        [TestMethod]
        public void AddingStudentShouldIncreaseNumberOfStudents()
        {
            Student student = new Student("Gosho", 40000);
            school.AddStudent(student);
            int numberOfStudents = school.Students.Count;

            Assert.AreEqual(1, numberOfStudents, "Student adding does not increase count");
        }

        [TestMethod]
        public void RemovingStudentShouldDecreaseNumberOfStudents()
        {
            Student firstStudent = new Student("Gosho", 40000);
            Student secondStudent = new Student("Pesho", 50000);

            school.AddStudent(firstStudent);
            school.AddStudent(secondStudent);
            school.RemoveStudent(secondStudent);
            int numberOfStudents = school.Students.Count;

            Assert.AreEqual(1, numberOfStudents, "Student removing does noe decrease count");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddingExistingStudentToListShouldThrowException()
        {
            Student firstStudent = new Student("Gosho", 40000);
            Student secondStudent = new Student("Pesho", 40000);

            school.AddStudent(firstStudent);
            school.AddStudent(secondStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingUnexistingStudentShouldThrowException()
        {
            Student student = new Student("Vanio", 23233);

            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullCourseShouldThrowException()
        {
            school.AddCourse(null);
        }

        [TestMethod]
        public void AddingCourseShouldIncreaseNumberOfCourses()
        {
            Course course = new Course("Maths");
            school.AddCourse(course);
            int numberOfStudents = school.Courses.Count;

            Assert.AreEqual(1, numberOfStudents, "Student adding does not increase count");
        }

        public void RemovingCourseShouldDecreaseNumberOfStudents()
        {
            Course firstStudent = new Course("Math");
            Course secondStudent = new Course("Physics");

            school.AddCourse(firstStudent);
            school.AddCourse(secondStudent);
            school.RemoveCourse(secondStudent);
            int numberOfCourses = school.Courses.Count;

            Assert.AreEqual(1, numberOfCourses, "Course removing does noe decrease count");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddingExistingCourseToListShouldThrowException()
        {
            Course course = new Course("Java");

            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingUnexistingCourseShouldThrowException()
        {
            Course course = new Course("Java");

            school.RemoveCourse(course);
        }
    }
}
