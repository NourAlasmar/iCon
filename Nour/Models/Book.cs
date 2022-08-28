using Nour.Enums;

namespace Nour.Models
{
    public class Book
    {
        public int Id { get; set; } = 1;
        public String Name { get; set; } = "Interstaller";
        public Categories MyCategories { get; set; } = Categories.Horror;
        
    }
}
