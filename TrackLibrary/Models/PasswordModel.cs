using System;
using System.Collections.Generic;
using System.Text;

namespace TrackLibrary.Models
{
    public class PasswordModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string Previous_password { get; set; }
        public string Fullname
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
