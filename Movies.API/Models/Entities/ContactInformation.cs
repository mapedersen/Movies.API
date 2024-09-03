namespace Movies.API.Models.Entities
{
    public class ContactInformation
    {
        public int ContactInformationId { get; set; }
        public string Email { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;

        // One-to-one relationship with Director
        public int DirectorId { get; set; }
        public Director Director { get; set; } = null!;
    }
}
