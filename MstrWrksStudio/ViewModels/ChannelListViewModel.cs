using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MstrWrksStudio.Models;

namespace MstrWrksStudio.ViewModels
{
    public class ChannelListViewModel 
    {
        public List<Channel> Channel { get; set; }
        public List<Post> Posts { get; set; }

    }
}