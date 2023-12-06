namespace Szkolenia.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        // Navigation property for the books authored by this author
        public List<Course> Courses { get; set; }
    }
}
