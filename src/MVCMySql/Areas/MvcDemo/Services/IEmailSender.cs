using System.Threading.Tasks;

namespace MVCMySql.Areas.MvcDemo.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
