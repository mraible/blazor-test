using System.Threading.Tasks;
using blazor.Domain;

namespace blazor.Domain.Services.Interfaces {
    public interface IMailService {
        Task SendPasswordResetMail(User user);
        Task SendActivationEmail(User user);
        Task SendCreationEmail(User user);
    }
}
