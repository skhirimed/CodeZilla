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
        public Account From { get; set; }
        public Account To { get; set; }
        //Foreign key
        [Column(Order = 2)]
        public int AccountFromID { get; set; }
        [Column(Order = 3)]
        public int AccountToID { get; set; }
        
    }
}
