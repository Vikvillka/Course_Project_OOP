using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Model
{
    public class TrainingUser
    {
        public int TrainingId { get; set; }
        public Training Training { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool Status { get; set; }

        public DateTime? AttendanceDate { get; set; }
    }
}
