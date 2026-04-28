namespace WebApplication1.DTOs
{
    public class RentalsDTO
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = null!;
        public List<MoviesDTO> Movies { get; set; } = new List<MoviesDTO>;
    }
}
