namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstMidName { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = [];
    }
}
