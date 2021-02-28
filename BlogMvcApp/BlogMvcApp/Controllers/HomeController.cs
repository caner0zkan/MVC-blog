using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                                .Select(i => new BlogModel()
                                {
                                    Id = i.Id,
                                    Title = i.Title.Length > 100 ? i.Title.Substring(0, 97) + "..." : i.Title,
                                    Comment = i.Comment,
                                    AddedDate = i.AddedDate,
                                    HomePage = i.HomePage,
                                    Confirmation = i.Confirmation,
                                    Image = i.Image
                                })
                                .Where(i => i.Confirmation == true && i.HomePage == true);


            return View(blogs.ToList());
        }
    }
}