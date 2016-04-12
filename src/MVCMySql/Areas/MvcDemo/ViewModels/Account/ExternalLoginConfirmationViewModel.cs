using System.ComponentModel.DataAnnotations;

namespace MVCMySql.Areas.MvcDemo.ViewModels.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
