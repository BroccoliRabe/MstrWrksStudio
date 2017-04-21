using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MstrWrksStudio.Models
{
    public class Post 
    {

        public byte Id { get; set; }
        public byte PostByUserId { get; set; }
        public byte ChannelId { get; set; }
        public string Message { get; set; }
        public DateTime PostTime { get; set; }
        

    }
}