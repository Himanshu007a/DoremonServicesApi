namespace DoremonServicesApi.Models
{
    public class DoremonCategory
    {
        public int DoremonId { get; set; }

        public int CategoryId { get; set; }

        public Doremon Doremon { get; set; }

        public Category Category { get; set; } 

    }
}
