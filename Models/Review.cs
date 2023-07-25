namespace DoremonServicesApi.Models
{
    public class Review
    {
        public int Id { get; set; } 

        public string Title { get; set; }
        public String Text { get; set; }

      public Doremon Doremon { get; set; }
        
public Reviewer Reviewer { get; set; }  
    }
}
