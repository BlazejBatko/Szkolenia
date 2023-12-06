namespace Szkolenia.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        // Foreign key for the Author relationship
        public int TrainerId { get; set; }

        // Navigation property for the author of this book
        public Trainer Trainer { get; set; }
    }
}
