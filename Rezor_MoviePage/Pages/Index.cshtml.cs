using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rezor_MoviePage.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "�������� ������ ��������"; // ��� CopyRight � Title ��������
    }
}
