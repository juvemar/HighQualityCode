namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        const string CourseNullException = "Course cannot be null.";
        const string StudentNullException = "Student cannot be null.";
        const string ExistingStudentException = "There is already a student with that id.";
        const string NotExistingStudentException = "This student does not exist in the list.";
        const string ExistingCourseException = "This course already exists in the list.";
        const string NotExistingCourseException = "This course does not exist in the list.";

        private ICollection<Course> courses;
        private ICollection<Student> students;

        public School()
        {
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(CourseNullException);
            }

            if (this.courses.Contains(course))
            {
                throw new ArgumentException(ExistingCourseException);
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(CourseNullException);
            }

            if (!this.courses.Contains(course))
            {
                throw new ArgumentException(NotExistingCourseException);
            }

            this.courses.Remove(course);
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(StudentNullException);
            }

            foreach (var currentStudent in this.students)
            {
                if (currentStudent.Id == student.Id)
                {
                    throw new ArgumentException(ExistingStudentException);
                }
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(StudentNullException);
            }

            if (!this.students.Contains(student))
            {
                throw new ArgumentException(NotExistingStudentException);
            }

            this.students.Remove(student);
        }
    }
}
