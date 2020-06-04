using System.Collections.Generic;
using System.Threading.Tasks;
using CleanAPI.Interfaces.Services.Communication;

namespace CleanAPI.Core.Service.Communication {
    public class EmailServices : IEmailServices {
        public async Task SendEmail(IEnumerable<string> recipient, string subject, string message){
            // Send Email
        }
    }
}