using System.ComponentModel.DataAnnotations;

namespace Rezor_MoviePage.Data;

public class Movie
{
    public required int Id { get; set; }
    [Required(ErrorMessage ="Вы не заполнили поле \"Название\"")]
    [StringLength(maximumLength:100, MinimumLength = 5)]
    public required string Title { get; set; }
    [Required(ErrorMessage = "Вы не заполнили поле \"Фото услуги\"")]
    public required string URL { get; set; }
    [Required(ErrorMessage = "Вы не заполнили поле \"Описание\"")]
    [StringLength(maximumLength: 500, MinimumLength = 5, ErrorMessage = "Описание услуги не превышает \"500 \" и не ниже 5 символов")]
    public required string Description { get; set; }
    [Required(ErrorMessage = "Вы не заполнили поле \"Стоимость\"")]
    [Range(100, 5000, ErrorMessage ="Цена услуги не превышает \"5000 \" и не ниже 100")]
    public required double Cost { get; set; }
}
