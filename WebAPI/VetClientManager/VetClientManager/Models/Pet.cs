namespace VetClientManager.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public int ClientId { get; set; }
    }
}
