namespace School
{
    using System;

    public class Student
    {
        const string NameEmptyException = "Name cannot be null or empty.";
        const string NameWhiteSpaceException = "Name can not be white space";
        const string IdRangeException = "Id must be between 10000 and 99999";
        const string CourseNullException = "Course can not be null";

        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
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

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(IdRangeException);
                }

                this.id = value;
            }
        }


        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(CourseNullException);
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(CourseNullException);
            }

            course.RemoveStudent(this);
        }
    }
}
