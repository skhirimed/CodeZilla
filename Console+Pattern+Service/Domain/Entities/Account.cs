using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [InverseProperty("To")]
        public ICollection<Message> MessagesRecieved { get; set; }
        [InverseProperty("From")]
        public ICollection<Message> MessagesSent { get; set; }

        public Account()
        {
            this.MessagesRecieved = new List<Message>();
            this.MessagesSent = new List<Message>();
        }
    }
}
