using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailLogger
{
    public static class EmailConstructor
    {
        public static Email CreateEmail(string recipient, string body)
        {
            return new Email(recipient, body);
        }
    }
    
    public class Email
    {
        public string recipient;
        public string body;
        public Email(string rec, string bod)
        {
            recipient = rec;
            body = bod;
        }
    }
}
