using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MstrWrksStudio.Models;
using MstrWrksStudio.ViewModels;

namespace MstrWrksStudio.Controllers
{
    public class ChannelController : Controller
    {
       
        // GET /Channel/ChannelList
        public ActionResult ChannelList()
        {
            var channels = new List<Channel>
            {
                new Channel { Id = 1, Name = "Test Channel 1", Posts = new List<Post>()}
            };
            var posts = new List<Post>
            {
                new Post { Id = 1, Message = "This is test message 1", PostTime = DateTime.Now },
                new Post { Id = 2, Message = "This is test message 2", PostTime = DateTime.Now }
            };

            var viewModel = new ChannelListViewModel
            {
                Channel = channels,
                Posts = posts
            };
            return View(viewModel);
        }
        // GET /Channel/Post
        public ActionResult Posts()
        {
            var posts = new List<Post>
            {
                new Post { Id = 1, Message = "This is test message 1", PostTime = DateTime.Now },
                new Post { Id = 2, Message = "This is test message 2", PostTime = DateTime.Now }
            };

            var viewModel = new ChannelListViewModel
            {
                Posts = posts
            };
            return View(viewModel);
        }
    }
}