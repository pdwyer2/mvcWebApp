using System;
using System.ComponentModel.DataAnnotations;

namespace MvcUserForm.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}