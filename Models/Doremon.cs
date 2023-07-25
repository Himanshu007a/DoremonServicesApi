namespace DoremonServicesApi.Models
{
    public class Doremon
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        
    public DateTime dateTime { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<DoremonOwner> DoremonOwners { get; set; }

        public ICollection<DoremonCategory> DoremonCategory { get; set; }

    }
}
