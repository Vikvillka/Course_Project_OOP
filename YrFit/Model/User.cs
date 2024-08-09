using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Model
{
    public class User
    {
       
        public int Id { get; set; }  
        public string Login { get; set; }
        public string HashedLogin { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[]? AvatarImg { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Action>? Actions { get; set; }
        public List<MediaTraining>? MediaTraining { get; set; }
        public ICollection<Training>? Trainings { get; set; }
        public Role Role { get; set; }

        public User()
        {
            Trainings = new List<Training>();
        }
    }


    public enum Role
    {
        Admin,
        User,
    }
}
