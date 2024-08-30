using System.ComponentModel.DataAnnotations;

namespace Rezor_MoviePage.ViewModel;

public class LoginViewModel
{
    public string EmailAddress { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
