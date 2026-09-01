namespace ContosoUniversity.Models
{
    // Assigned Course to an Instructor
    // Instructor to Course - Many to Many
    public class CourseAssignment
    {
        public int InstructorID { get; set; }

        public int CourseID { get; set; }

        // InstructorID and CourseID are called composite keys
        // Together, they make records unique

        public Instructor Instructor { get; set; }

        public Course Course { get; set; }
    }
}
