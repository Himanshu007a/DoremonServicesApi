namespace DoremonServicesApi.Models
{
    public class DoremonOwner

    {
        public int  DoremonId { get; set; }
        public int OwnerId { get; set; }

        public Doremon Doremon { get; set; }

        public Owner Owner { get; set; }
    }
}
