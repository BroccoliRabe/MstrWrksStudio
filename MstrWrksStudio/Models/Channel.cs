using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MstrWrksStudio.ViewModels;
namespace MstrWrksStudio.Models
{
    public class Channel 
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<Channel> Channels { get; set; }

 
    }
}