using System.ComponentModel.DataAnnotations;

namespace Rezor_MoviePage.Model;

public class HallCinema
{
    [Key]
    public required int NumberHall { get; set; }
    public required int CountRows { get; set; }
    public required int CountSeats { get; set; }
}
