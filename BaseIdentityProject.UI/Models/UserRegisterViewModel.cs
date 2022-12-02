using System.ComponentModel.DataAnnotations;

namespace BaseIdentityProject.UI.Models
{
    public class UserRegisterViewModel
    {
        [Required (ErrorMessage ="Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir Giriniz.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        public string ConfirmPassword { get; set; }
    }
}
