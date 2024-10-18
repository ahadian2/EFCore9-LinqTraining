namespace LinqTraining.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Family { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string? City { get; set; }
    }
}
