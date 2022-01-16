using Microsoft.EntityFrameworkCore;
using System;


namespace WebApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Nationality { get; set; }
    }

  
}
