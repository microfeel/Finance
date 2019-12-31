using System;
using System.Collections.Generic;
using System.Text;
 

namespace MicroFeel.Finance.Models
{
    public class LoginParameter
    {
     
        public User User { get; set; }
    }

    public class User
    {
        public User(string user_id, string password)
        {
            User_id = user_id;
            Password = password;
        }

        /// <summary>
        /// 操作员编码
        /// </summary>
       
        public string User_id { get; set; }
       
        public string Password { get; set; }
    }
}
