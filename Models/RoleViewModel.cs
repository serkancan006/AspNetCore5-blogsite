using System.ComponentModel.DataAnnotations;

namespace AspNetCore5_blogsite.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Rol adı giriniz")]
        public string name { get; set; }
    }
}
