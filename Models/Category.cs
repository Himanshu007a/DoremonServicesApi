namespace DoremonServicesApi.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<DoremonCategory>DoremonCategories { get; set; }
    }
}
