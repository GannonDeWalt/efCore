namespace App 
{
    public class Grade {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public float GradeP { get; set; }
        public Student student {get; set;}
    }
}