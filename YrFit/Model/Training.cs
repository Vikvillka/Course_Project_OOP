using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Model
{
    public class Training 
    {
        public int ID { get; set; }  
        public string Type { get; set; }
        public DateTime DateTime { get; set; }
        public string NameTrainer { get; set; }
        public string Description { get; set; }
        public int Prise { get; set; }
        public int Location { get; set; }
        public int Duration { get; set; }
        public int MaxPeople { get; set; }
        public ICollection<User>? Users { get; set; }

        public Training()
        {
           
            Users = new List<User>();
        }
    }

}
