using System.Threading.Tasks;

namespace MVCMySql.Areas.MvcDemo.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
