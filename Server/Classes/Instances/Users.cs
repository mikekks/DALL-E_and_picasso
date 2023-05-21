using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Server.Classes.Instances
{
    public class Users
    {
        public string userId, password, email, answer;

        public Users(string userId, string password,
            string email, string answer)
        {
            this.userId = userId;
            this.password = password;
            this.email = email;
            this.answer = answer;
        }
    }

}
