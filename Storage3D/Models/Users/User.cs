using System.Collections.Generic;

namespace Storage3D.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public List<Email> Emails { get; set; }

        public string Role { get; set; }
    }
}
