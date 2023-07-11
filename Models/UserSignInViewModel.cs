using System.ComponentModel.DataAnnotations;

namespace AspNetCore5_blogsite.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı adını girin")]
        public string username { get; set; }


        [Required(ErrorMessage = "Lütfen şifrnizi girin")]
        public string password { get; set; }
    }
}
