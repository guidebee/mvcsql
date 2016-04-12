using System.ComponentModel.DataAnnotations;

namespace MVCMySql.Areas.MvcDemo.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
