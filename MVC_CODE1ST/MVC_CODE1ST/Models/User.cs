using MVC_CODE1ST.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BCrypt.Net;

namespace MVC_CODE1ST.Models
{
    [Table("TB_M_User")]
    public class User : BaseModel
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class Hashing
    {
        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        public  static bool ValidatePassword(string password, string correctHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, correctHash);
        }
    }
}