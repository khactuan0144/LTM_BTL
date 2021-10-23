using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendBulkEmail.DTO
{
    class User
    {
        private string email;
        private string pass;
        private string name;
        private string birhday;
        private string phone;

        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Name { get => name; set => name = value; }
        public string Birhday { get => birhday; set => birhday = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
