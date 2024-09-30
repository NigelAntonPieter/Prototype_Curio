using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace FakeApi.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        //public int LevelId { get; set; }
        //public Level Level { get; set; }
        public int LearningPathId { get; set; }
        public Learningpath LearningPath { get; set; }
        public string Specialization { get; set; }
        public string ImagePath { get; set; }
        public string ImagePathWithFallBack => ImagePath ?? "/Assets/images.jpeg";
        public bool IsOpen { get; set; } = true;
        //public ICollection<FavoriteCompany> FavoriteCompanies { get; set; } = new List<FavoriteCompany>();
        //public ICollection<User> Users { get; set; }
        //public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
