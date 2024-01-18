using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _11_Amazon
{
    internal class Password
    {
        private string username;
        private string password;

        public Password()
        {

        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPasswort(string password)
        {
            this.password = password;
        }

        public void PassWordKontroller()
        {
            Console.WriteLine("");
        }

    }
}
