using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage3D.Models.Users
{
    public class Email
    {
        public int Id { get; set; }

        public string AdressEmail { get; set; }

        public bool MainEmail { get; set; }
    }
}