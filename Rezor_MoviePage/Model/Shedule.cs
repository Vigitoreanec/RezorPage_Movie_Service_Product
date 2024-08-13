using System.ComponentModel.DataAnnotations;
namespace Rezor_MoviePage.Model;

public class Shedule
{
    public required int SheduleId { get; set; }
    [Required]
    public required DateTime StartFilm { get; set; }
    [Required]
    public required DateTime EndFilm { get; set; }
    [Required]
    public required Movie Movie { get; set; }
    [Required]
    public required HallCinema HallCinema { get; set; }
    [Required(ErrorMessage = "Вы не заполнили поле \"Стоимость\"")]
    [Range(100, 5000, ErrorMessage = "Цена услуги не превышает \"5000 \" и не ниже 100")]
    public required int Cost { get; set; }
}
