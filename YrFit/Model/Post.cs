using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Model
{
    public abstract class Post
    {
        public int Id { get; set; }
        public PostCategory PostCategory { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
    public enum PostCategory
    {
        Actions,
        Trainings,
    }
}
