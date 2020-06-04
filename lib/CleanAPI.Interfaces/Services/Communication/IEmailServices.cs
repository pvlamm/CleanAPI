using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanAPI.Interfaces.Services.Communication{
    public interface IEmailServices {
        Task SendEmail(IEnumerable<string> recipient, string subject, string message);
    }
}