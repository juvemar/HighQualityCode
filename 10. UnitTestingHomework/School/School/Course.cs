namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        const int MaxStudentsInCourse = 30;
        const string NameEmptyException = "Name cannot be null or empty.";
        const string NameWhiteSpaceException = "Name can not be white space.";
        const string StudentNullException = "Student cannot be null.";
        const string StudentsCountException = "The number of the students must be bellow 30.";
        const string ExistingStudentException = "This student already exist in the list.";
        const string NotExistingStudentException = "This student does not exist in the list.";

        private ICollection<Student> students;
        private string name;

        public Course(string name)
        {
            this.students = new List<Student>();
            this.Name = name;
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameEmptyException);
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(NameWhiteSpaceException);
                }

                this.name = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(StudentNullException);
            }

            if (this.students.Count == 29)
            {
                throw new ArgumentException(StudentsCountException);
            }

            if (this.students.Contains(student))
            {
                throw new ArgumentException(ExistingStudentException);
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
