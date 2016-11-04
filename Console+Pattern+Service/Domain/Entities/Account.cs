using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public String Login { get; set; }
        //prop de navigation
        public ICollection<Message> Messages { get; set; }
    }
}
