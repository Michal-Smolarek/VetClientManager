namespace VetClientManager.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public int PetId { get; set; }
    }
}
