using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IMailService
    {
        public Task SendMessageAsync(string subject, string html, string to, string? from= null);
    }
}
