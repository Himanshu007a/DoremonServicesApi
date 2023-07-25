namespace DoremonServicesApi.Models
{
    public class Country
    {
        public int id { get; set; }

        public string Name { get; set; }    

        public ICollection<Country> Countries { get; set;}
    }
}
