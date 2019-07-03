using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockProject.Model
{

    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }


}