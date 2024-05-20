namespace api.DataModels
{
    public class Course
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public string CourseFee { get; set; }

        public DateTime StartDate { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
