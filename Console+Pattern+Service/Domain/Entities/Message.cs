using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Message
    {
        [Column(Order = 1)]
        public int MessageID { get; set; }
        public String Text { get; set; }
        public bool Read { get; set; }
        //Prop de navifgation
        public virtual Account From { get; set; }
        public virtual Account To { get; set; }
        //Foreign key
        [ForeignKey("From"),Column(Order = 2)]
        public int AccountFromID { get; set; }
        [ForeignKey("To"),Column(Order = 3)]
        public int AccountToID { get; set; }
        
    }
}
