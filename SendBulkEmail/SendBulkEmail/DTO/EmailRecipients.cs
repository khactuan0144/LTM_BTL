using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendBulkEmail.DTO
{
    class EmailRecipients
    {
        private string idEmailContent;
        private string emailRecipient;
        private string sender;

        public string IdEmailContent { get => idEmailContent; set => idEmailContent = value; }
        public string EmailRecipient { get => emailRecipient; set => emailRecipient = value; }
        public string Sender { get => sender; set => sender = value; }
    }
}
