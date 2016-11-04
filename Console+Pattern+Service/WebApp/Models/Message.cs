using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public String Text { get; set; }
        public bool Read { get; set; }
        public Account From { get; set; }
    }
}